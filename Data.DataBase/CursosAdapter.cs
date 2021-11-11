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
    public class CursosAdapter: Adapter
    {
        public CursosAdapter():base(){}

        public Curso getOne(int id)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_curso], [cursos].[id_materia],[cursos].[id_comision], [anio_calendario], [cupo], [desc_materia], [desc_comision]" +
                " FROM [Academia].[dbo].[cursos] inner join [Academia].[dbo].[comisiones] " +
                "on [cursos].[id_comision]= [comisiones].[id_comision] " +
                "inner join [Academia].[dbo].[materias] " +
                "on [cursos].[id_materia]= [materias].[id_materia]" +
                $" WHERE [id_curso]={id}");
            reader.Read();
            string descripcion = $"{reader.GetString(5)}-{reader.GetString(6)} ({reader.GetInt32(3)})";
            Curso curso = new Curso(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), descripcion);
            reader.Close();
            this.CloseConnection();
            return curso;
        }

        public List<Curso> getAll()
        {
            List<Curso> cursos = new List<Curso>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_curso], [cursos].[id_materia],[cursos].[id_comision], [anio_calendario], [cupo], [desc_materia], [desc_comision]" +
                " FROM [Academia].[dbo].[cursos] inner join [Academia].[dbo].[comisiones] " +
                "on [cursos].[id_comision]= [comisiones].[id_comision] " +
                "inner join [Academia].[dbo].[materias] " +
                "on [cursos].[id_materia]= [materias].[id_materia]");
            while(reader.Read())
            {
                string descripcion = $"{reader.GetString(5)}-{reader.GetString(6)} ({reader.GetInt32(3)})";
                Curso curso = new Curso(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), descripcion);
                cursos.Add(curso);
            }
            reader.Close();
            this.CloseConnection();
            return cursos;
        }

        public void SaveChanges(Curso c)
        {
            try
            {
                SqlCommand cmdSave = new SqlCommand("UPDATE cursos SET id_materia=@materia, " +
                    "id_comision=@com, anio_calendario=@y, cupo=@cupo " +
                    "WHERE id_curso=@id", sqlConnection);
                cmdSave.Parameters.Add("@materia", System.Data.SqlDbType.Int).Value = c.IDMateria;
                cmdSave.Parameters.Add("@com", System.Data.SqlDbType.Int).Value = c.IDComision;
                cmdSave.Parameters.Add("@y", System.Data.SqlDbType.Int).Value = c.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", System.Data.SqlDbType.Int).Value = c.Cupo;
                cmdSave.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = c.ID;

                this.OpenConnection();
                cmdSave.ExecuteNonQuery();
            }
            catch(SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Delete(int id)
        {
            try
            {
                SqlCommand cmdDelete = new SqlCommand("DELETE cursos FROM cursos WHERE id_curso=@id", sqlConnection);
                cmdDelete.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                this.OpenConnection();
                cmdDelete.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                throw new Exception("Es posible que haya inscripciones en el curso " + se.Message);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void AddNew(Curso c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[cursos] ([id_materia], [id_comision], [anio_calendario], [cupo]) " +
                    "VALUES (@materia, @comision, @y, @cupo)", sqlConnection);
                cmd.Parameters.Add("@materia", System.Data.SqlDbType.Int).Value = c.IDMateria;
                cmd.Parameters.Add("@comision", System.Data.SqlDbType.Int).Value = c.IDComision;
                cmd.Parameters.Add("@y", System.Data.SqlDbType.Int).Value = c.AnioCalendario;
                cmd.Parameters.Add("@cupo", System.Data.SqlDbType.Int).Value = c.Cupo;

                this.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<Curso> getbyPlan(int idPlan)
        {
            List<Curso> cursos = new List<Curso>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_curso], [cursos].[id_materia],[cursos].[id_comision], [anio_calendario], [cupo], [desc_materia], [desc_comision]" +
                " FROM [Academia].[dbo].[cursos] inner join [Academia].[dbo].[comisiones] " +
                "on [cursos].[id_comision]= [comisiones].[id_comision] " +
                "inner join [Academia].[dbo].[materias] " +
                "on [cursos].[id_materia]= [materias].[id_materia]" +
                " inner join [Academia].[dbo].[planes]" +
                " on [materias].[id_plan]= [planes].[id_plan] " +
                $"where [planes].[id_plan]= {idPlan}");
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

        public List<Curso> getCursosDisponibles(int idPlan, int idAlumno)
        {
            List<Curso> cursos = new List<Curso>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_curso], [cursos].[id_materia],[cursos].[id_comision], [anio_calendario], [cupo], [desc_materia], [desc_comision]" +
                " FROM [Academia].[dbo].[cursos] inner join [Academia].[dbo].[comisiones] " +
                "on [cursos].[id_comision]= [comisiones].[id_comision] " +
                "inner join [Academia].[dbo].[materias] " +
                "on [cursos].[id_materia]= [materias].[id_materia]" +
                " inner join [Academia].[dbo].[planes]" +
                " on [materias].[id_plan]= [planes].[id_plan] " +
                $"where [planes].[id_plan]= {idPlan} and [cursos].id_curso NOT IN " +
                "(select [cursos].id_curso from [cursos] inner join [alumnos_inscripciones] " +
                "on [cursos].id_curso = [alumnos_inscripciones].id_curso " +
                $"where [alumnos_inscripciones].id_alumno={idAlumno}) " +
                $"AND [cursos].[cupo] >= 1");
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

      /*  public List<Curso> getCursosInscripto(int idPlan, int idAlumno)
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
        }*/

        public List<DocenteCurso> GetDocentesCursos()
        {
            List<DocenteCurso> dc = new List<DocenteCurso>();
            this.OpenConnection();
            try
            {
                SqlDataReader rdr = this.ExecuteReader("SELECT id_dictado, id_curso, id_docente, cargo " +
                    "FROM [Academia].[dbo].[docentes_cursos]");
                while (rdr.Read())
                {
                    DocenteCurso dcur = new DocenteCurso { ID=rdr.GetInt32(0)};
                    dc.Add(dcur);
                }
                rdr.Close();
            }
            catch(Exception ex)
            {
                throw new Exception("BD>> No fue posible recuperar los cursos de docentes:" + ex.Message + "||");
            }
            finally
            {
                this.CloseConnection();
            }

            return dc;
        }

        public List<Curso> GetCursoSinDocente()
        {
            List<Curso> cur = new List<Curso>();
            
            this.OpenConnection();
            try
            {                
                SqlDataReader reader = this.ExecuteReader("SELECT  a.id_curso, a.id_materia, id_comision, anio_calendario, cupo, desc_materia  " +
                    "FROM [Academia].[dbo].[cursos] a " +
                    "INNER JOIN[Academia].[dbo].[materias]  mat " +
                    "ON a.id_materia = mat.id_materia " +
                    "LEFT JOIN [Academia].[dbo].[docentes_cursos] b " +
                    "ON a.id_curso = b.id_curso  " +
                    "WHERE b.id_curso IS NULL");
                while (reader.Read())
                {
                    //int id, int idmat, int idcom, int cale, int cupo, string desc
                    Curso c = new Curso(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5)) ;
                    cur.Add(c);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("BD>> No fue posible recuperar los cursos de docentes:" + ex.Message + "||");
            }
            finally
            {
                this.CloseConnection();
            }
            return cur;
        }

        public List<Curso> getCursobyIdPlan (int idPlan)
        { 
            List<Curso> cursos = new List<Curso>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT id_curso, c.id_materia, c.id_comision, anio_calendario, cupo, desc_materia " +
                "FROM [Academia].[dbo].[cursos] c " +
                "INNER JOIN [Academia].[dbo].[materias] m " +
                "ON c.id_materia = m.id_materia " +
                "INNER JOIN [Academia].[dbo].[comisiones] com " +
                "ON c.[id_comision]= com.[id_comision] " +
                "INNER JOIN [Academia].[dbo].[planes] p " +
                "ON com.[id_plan] = p.[id_plan] " +
                $"WHERE p.[id_plan] = {idPlan}" );
            while (reader.Read())
            {
                Curso curso = new Curso(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5));
                cursos.Add(curso);
            }
            reader.Close();
            this.CloseConnection();
            return cursos;
        }
    }
}
