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
                "on [cursos].id_comision= [comisiones].id_comision" +
                "inner join [Academia].[dbo].[comisiones] " +
                "on [cursos].id_materia= [materias].id_materia" +
                $" WHERE [id_curso]={id}");
            reader.Read();
            string descripcion = $"{reader.GetString(6)}-{reader.GetString(7)}";
            Curso curso = new Curso(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(4), reader.GetInt32(5), descripcion);
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
                "on [cursos].id_comision= [comisiones].id_comision" +
                "inner join [Academia].[dbo].[comisiones] " +
                "on [cursos].id_materia= [materias].id_materia");
            while(reader.Read())
            {
                string descripcion = $"{reader.GetString(6)}-{reader.GetString(7)} ({reader.GetInt32(3)})";
                Curso curso = new Curso(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(4), reader.GetInt32(5), descripcion);
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
                    "WHERE id_curso=@id");
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
                SqlCommand cmdDelete = new SqlCommand("DELETE cursos FROM cursos WHERE id_curso=@id");
                cmdDelete.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                this.OpenConnection();
                cmdDelete.ExecuteNonQuery();
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

        public void AddNew(Curso c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO cursos ([id_materia], [id_comision], [anio_calendario], [cupo]) " +
                    "VALUES (@materia, @comision, @y, @cupo)");
                cmd.Parameters.Add("@materia", System.Data.SqlDbType.Int).Value = c.IDMateria;
                cmd.Parameters.Add("@com", System.Data.SqlDbType.Int).Value = c.IDComision;
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
    }
}
