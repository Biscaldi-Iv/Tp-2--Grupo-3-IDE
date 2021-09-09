using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter : Adapter
    {
        public AlumnoInscripcionAdapter() : base() { }
        public List<Curso> getCursosInscripto(int idPlan, int idAlumno)
        {
            List<Curso> cursos = new List<Curso>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [cursos].[id_curso], [cursos].[id_materia],[cursos].[id_comision], [anio_calendario], [cupo], [desc_materia], [desc_comision]" +
                " FROM [Academia].[dbo].[cursos] inner join [Academia].[dbo].[comisiones] " +
                "on [cursos].[id_comision]= [comisiones].[id_comision] " +
                "inner join [Academia].[dbo].[materias] " +
                "on [cursos].[id_materia]= [materias].[id_materia]" +
                " inner join [Academia].[dbo].[planes]" +
                " on [materias].[id_plan]= [planes].[id_plan] " +
                "inner join [Academia].[dbo].[alumnos_inscripciones] " +
                "on [alumnos_inscripciones].[id_curso]=[cursos].[id_curso]" +
                $"where [planes].[id_plan]= {idPlan} and [alumnos_inscripciones].[id_alumno]={idAlumno}");
            while (reader.Read())
            {
                string descripcion = $"{reader.GetString(5)}-{reader.GetString(6)} ({reader.GetInt32(3)})";
                Curso curso = new Curso(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), descripcion);
                cursos.Add(curso);
            }
            reader.Close();
            this.CloseConnection();
            return cursos;
        }

        public void Inscribirse(int IdAlumno, int IdCurso)
        {
            this.OpenConnection();
            using (var transaccion = sqlConnection.BeginTransaction()) 
            {
                try
                {
                    SqlCommand cmdInscripcion = new SqlCommand("INSERT INTO [Academia].[dbo].[alumnos_inscripciones] " +
                            "(id_alumno, id_curso, condicion) " +
                            "VALUES  (@alumno, @curso, @condicion)", sqlConnection);
                    cmdInscripcion.Transaction = transaccion;
                    cmdInscripcion.Parameters.Add("@alumno", System.Data.SqlDbType.Int).Value = IdAlumno;
                    cmdInscripcion.Parameters.Add("@curso", System.Data.SqlDbType.Int).Value = IdCurso;
                    cmdInscripcion.Parameters.Add("@condicion", System.Data.SqlDbType.VarChar).Value = "Inscripto";

                    SqlCommand cmdUpdateCurso = new SqlCommand("UPDATE [Academia].[dbo].[cursos] SET " +
                        "cupo = @cupo " +
                        "WHERE id_curso = @curso", sqlConnection);
                    cmdUpdateCurso.Transaction = transaccion;
                    Curso c = new CursosAdapter().getOne(IdCurso);
                    cmdUpdateCurso.Parameters.Add("@cupo", System.Data.SqlDbType.Int).Value = c.Cupo - 1;
                    cmdUpdateCurso.Parameters.Add("@curso", System.Data.SqlDbType.Int).Value = IdCurso;                    
                    cmdInscripcion.ExecuteNonQuery();
                    cmdUpdateCurso.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    transaccion.Rollback();
                    throw new Exception(e.Message);
                }
                finally
                {
                    transaccion.Commit();           
                    this.CloseConnection();
                }
            }

        }
    }
}
