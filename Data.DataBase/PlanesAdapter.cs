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
            SqlDataReader reader = this.ExecuteReader("SELECT [id_plan],[desc_plan],[id_especialidad] FROM [Academia].[dbo].[planes] ");
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
                $" WHERE [id_plan]={ID}");
            reader.Read();
            Plan p = new Plan(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            CloseConnection();

            return p;
        }

        public Plan GetByDesc(string desc)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_plan],[desc_plan],[id_especialidad] FROM [Academia].[dbo].[planes]" +
                $" WHERE [desc_plan]=\'"+desc+"\'");
            reader.Read();
            Plan p = new Plan(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            CloseConnection();

            return p;
        }

        public void Delete(int ID)
        {
            try
            {
                SqlCommand cmdSave = new SqlCommand(
                    "DELETE planes FORM " +
                    "planes " +
                    "WHERE id_plan=@id", sqlConnection);
                cmdSave.Parameters.Add("@id", System.Data.SqlDbType.Int).Value =ID;
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

        public void SaveChanges(Plan pl)
        {
            try
            {
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE planes SET " +
                    "desc_plan=@d_espec " +
                    "WHERE id_plan=@id", sqlConnection);
                cmdSave.Parameters.Add("@d_espec", System.Data.SqlDbType.VarChar, 50).Value = pl.Descripcion;
                cmdSave.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = pl.ID;
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

        public void AddNew(Plan pl)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_add_plan", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@d_plan", pl.Descripcion);
                cmd.Parameters.AddWithValue("@id_esp", pl.IDEspecialidad);
                this.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                this.CloseConnection();
            }

        }
    }
}
