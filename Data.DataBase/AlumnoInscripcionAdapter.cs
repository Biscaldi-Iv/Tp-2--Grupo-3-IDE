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
        public List<AlumnoInscripcion> getCursosInscripto(int idAlumno)
        {
            List<AlumnoInscripcion> ai = new List<AlumnoInscripcion>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT id_inscripcion, id_alumno, id_curso, condicion, nota " +
                "FROM [dbo].[alumnos_inscripciones]" +
                $"where [alumnos_inscripciones].[id_alumno]={idAlumno}");
            while (reader.Read())
            {           //(string condicion, int iDAlumno, int iDCurso, int nota)
                AlumnoInscripcion a = new AlumnoInscripcion(reader.GetInt32(0), reader.GetString(3), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(4));
                ai.Add(a);
            }
            reader.Close();
            this.CloseConnection();
            return ai;
        }

        public void Inscribirse(int IdAlumno, int IdCurso)
        {
            this.OpenConnection();
            using (var transaccion = sqlConnection.BeginTransaction()) 
            {
                try
                {
                    SqlCommand cmdInscripcion = new SqlCommand("INSERT INTO [Academia].[dbo].[alumnos_inscripciones] " +
                            "(id_alumno, id_curso, condicion, nota) " +
                            "VALUES  (@alumno, @curso, @condicion, 0)", sqlConnection);
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

        public void SaveChanges(AlumnoInscripcion alumnoActual)
        {
            try
            {
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE alumnos_inscripciones SET " +                   
                    "id_alumno=@idAlu," +
                    "id_curso=@idCur, " +
                    "condicion=@cond," +
                    "nota=@nota " +
                    "WHERE id_inscripcion=@id", sqlConnection);
                cmdSave.Parameters.Add("@idAlu", System.Data.SqlDbType.Int).Value = alumnoActual.IDAlumno;
                cmdSave.Parameters.Add("@idCur", System.Data.SqlDbType.Int).Value = alumnoActual.IDCurso;
                cmdSave.Parameters.Add("@cond", System.Data.SqlDbType.VarChar, 50).Value = alumnoActual.Condicion;
                cmdSave.Parameters.Add("@nota", System.Data.SqlDbType.Int).Value = alumnoActual.Nota;
                cmdSave.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = alumnoActual.ID;
                this.OpenConnection();
                cmdSave.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e.InnerException;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        

        public List<AlumnoInscripcion> getAll()
        {
            List<AlumnoInscripcion> ai = new List<AlumnoInscripcion>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_inscripcion], [id_alumno], [id_curso], [condicion], [nota] FROM [dbo].[alumnos_inscripciones]");
            while (reader.Read())
            {           //(string condicion, int iDAlumno, int iDCurso, int nota)
                AlumnoInscripcion a = new AlumnoInscripcion(reader.GetInt32(0),reader.GetString(3), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(4));
                ai.Add(a);
            }
            reader.Close();
            this.CloseConnection();
            return ai;
        }

        public AlumnoInscripcion getOne(int IDinscripcion)
        {
            
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_inscripcion], [id_alumno], [id_curso], [condicion], [nota] FROM [dbo].[alumnos_inscripciones] " +
                $"WHERE id_inscripcion = {IDinscripcion}");
            reader.Read();
                       //(string condicion, int iDAlumno, int iDCurso, int nota)
            AlumnoInscripcion a = new AlumnoInscripcion(reader.GetInt32(0), reader.GetString(3), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(4));     
            reader.Close();
            this.CloseConnection();
            return a;
        }
    }
}
