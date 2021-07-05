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
    public class PlanesAdapter : Adapter
    {
        public PlanesAdapter() : base() { }

        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_plan],[desc_plan],[id_especialidad] FROM [Academia].[dbo].[planes]");
            while (reader.Read())
            {
                Plan p = new Plan(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                planes.Add(p);
            }
            reader.Close();
            this.CloseConnection();

            return planes;
        }

        public Plan GetOne(int ID)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_plan],[desc_plan],[id_especialidad] FROM [Academia].[dbo].[planes]" +
                $" WHERE [id_especialidad]={ID}");
            reader.Read();
            Plan p = new Plan(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            CloseConnection();

            return p;
        }

        public void Delete(int ID)
        {
            try
            {
                SqlCommand cmdDelete = new SqlCommand(
                    "DELETE planes FROM " +
                    "planes" +
                    "WHERE id_plan=@id", sqlConnection);
                cmdDelete.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = ID;
                this.OpenConnection();
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

        public void SaveChanges(Plan pl)
        {
            try
            {
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE planes SET " +
                    "desc_plan=@d_espec" +
                    "WHERE id_plan=@id", sqlConnection);
                cmdSave.Parameters.Add("@d_espec", System.Data.SqlDbType.VarChar, 50).Value = pl.Descripcion;
                cmdSave.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = pl.ID;
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

        public void AddNew(Plan pl)
        {

            try
            {
                SqlCommand cmdnew = new SqlCommand(
                "insert into planes(desc_plan, id_especialidad) " +
                "Values(@d_plan, @id_esp) " +
                "selected @@identity", sqlConnection);
                cmdnew.Parameters.Add("@d_plan", System.Data.SqlDbType.VarChar, 50).Value = pl.Descripcion;
                cmdnew.Parameters.Add("@id_esp", System.Data.SqlDbType.Int).Value = pl.IDEspecialidad;
                this.OpenConnection();
                cmdnew.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                Exception ExcepcionNOManejada = new Exception("Error al crear el curso", Ex);
                throw ExcepcionNOManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }
    }
}
