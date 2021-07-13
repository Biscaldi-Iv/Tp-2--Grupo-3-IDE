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
    public class ComisionAdapter : Adapter
    {
        public ComisionAdapter() : base()
        {

        }


        public List<Comision> GetAll()
        {
            List<Comision> com = new List<Comision>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_comision], [desc_comision],[anio_especialidad],[id_plan] FROM [Academia].[dbo].[comisiones]"); // falta agregar state en la base de datos de tipo bit
            while (reader.Read())
            {
                Comision c = new Comision(reader.GetInt32(0), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(1)); // 
                com.Add(c);
            }
            reader.Close();
            this.CloseConnection();

            return com;
        }

        public Business.Entities.Comision GetOne(int ID)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT[id_comision], [desc_comision],[anio_especialidad],[id_plan]" +
                "FROM [Academia].[dbo].[comisiones]" +
                $" WHERE [id_comision]={ID}");
            reader.Read();
            Comision c = new Comision(reader.GetInt32(0), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(1));
            this.CloseConnection();

            return c;
        }

        public void Delete(int ID)
        {
            try
            {
                SqlCommand cmdDelete = new SqlCommand(
                    "DELETE comisiones FROM " +
                    "comisiones " +
                    "WHERE id_comision=@id", sqlConnection);
                cmdDelete.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = ID;
                this.OpenConnection();
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.CloseConnection();
            }
        }
        //para modificar
        public void SaveChanges(Comision comision)
        {
            try
            {
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE comisiones SET " +
                    "desc_comision=@d_com , anio_especialidad=@anio" + 
                    " WHERE id_comision=@id_com", sqlConnection);
                cmdSave.Parameters.Add("@d_com", System.Data.SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdSave.Parameters.Add("@anio", System.Data.SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_com", System.Data.SqlDbType.Int).Value = comision.ID;
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

        public void AddNew(Comision com)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[comisiones] ([desc_comision] ,[anio_especialidad] ,[id_plan])" +
                    "VALUES (@d_com, @anio, @plan)", sqlConnection);
                cmd.Parameters.Add("@d_com", System.Data.SqlDbType.VarChar, 50).Value = com.Descripcion;
                cmd.Parameters.Add("@anio", System.Data.SqlDbType.Int).Value = com.AnioEspecialidad;
                cmd.Parameters.Add("@plan", System.Data.SqlDbType.Int).Value = com.IDPlan;

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
    }
}


