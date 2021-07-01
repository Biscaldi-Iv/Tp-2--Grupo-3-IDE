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
            
            return es;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand(
                    "DELETE especialidades FROM " +
                    "especialidades" +
                    "WHERE id_especialidad=@id", sqlConnection);
                cmdDelete.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
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
         //para modificar
        public void Save(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE especialidades SET " +
                    "desc_especialidad=@d_espec" +
                    "WHERE id_especialidad=@id", sqlConnection);
                cmdSave.Parameters.Add("@d_espec", System.Data.SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
                cmdSave.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = especialidad.ID;
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

        public void AddNew(Especialidad esp) 
        {
            
            try
            {
                this.OpenConnection();
                SqlCommand cmdnew = new SqlCommand(
                "insert into especialidades(desc_especialidad) " +
                "Values(@d_espcialidad) " +
                "selected @@identity", sqlConnection);
                cmdnew.Parameters.Add("@d_especialidad", System.Data.SqlDbType.VarChar, 50).Value = esp.Descripcion;
                cmdnew.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }
    }
}

