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
    public class EspecialidadAdapter: Adapter
    {
        public EspecialidadAdapter():base()
        {
            
        }


        public List<Especialidad> GetAll()
        {
            List<Especialidad> esp = new List<Especialidad>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_especialidad], [desc_especialidad] FROM [Academia].[dbo].[especialidades]");
            while(reader.Read())
            {
                Especialidad es = new Especialidad(reader.GetInt32(0), reader.GetString(1));
                esp.Add(es);
            }
            reader.Close();
            this.CloseConnection();

            return esp;
        }

        public Business.Entities.Especialidad GetOne(int ID)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_especialidad], [desc_especialidad] " +
                "FROM [Academia].[dbo].[especialidades]" +
                $" WHERE [id_especialidad]={ID}");
            reader.Read();
            Especialidad es = new(reader.GetInt32(0), reader.GetString(1));
            reader.Close();
            this.CloseConnection();
            
            return es;
        }

        public void Delete(int ID)
        {
            try
            {
                SqlCommand cmdDelete = new SqlCommand(
                    "DELETE especialidades FROM " +
                    "especialidades " +
                    "WHERE id_especialidad=@id", sqlConnection);
                cmdDelete.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = ID;
                this.OpenConnection();
                cmdDelete.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.CloseConnection();
            }
        }
         //para modificar
        public void SaveChanges(Especialidad especialidad)
        {
            try
            {
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE especialidades SET " +
                    "desc_especialidad=@d_espec " +
                    "WHERE id_especialidad=@id", sqlConnection);
                cmdSave.Parameters.Add("@d_espec", System.Data.SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
                cmdSave.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = especialidad.ID;
                this.OpenConnection();
                cmdSave.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void AddNew(Especialidad esp) 
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand("sp_add_especialidad", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@d_especialidad", esp.Descripcion);
                this.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                this.CloseConnection();
            }

        }

        public Especialidad GetByDesc(string desc)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_especialidad], [desc_especialidad] " +
                "FROM [Academia].[dbo].[especialidades]" +
                " WHERE [desc_especialidad]=\'"+desc+"\'");
            reader.Read();
            Especialidad es = new(reader.GetInt32(0), reader.GetString(1));
            reader.Close();
            CloseConnection();

            return es;
        }
    }
}

