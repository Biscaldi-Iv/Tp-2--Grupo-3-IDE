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
            SqlDataReader reader = this.ExecuteReader("SELECT [id_comision], [desc_comision],[anio_especialidad],[id_plan] FROM [Academia].[dbo].[comisiones] WHERE [state]=1"); // falta agregar state en la base de datos de tipo bit
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
                $" WHERE [id_comision]={ID} and [state]=1");
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
                    "UPDATE comisiones SET " +
                    "state=0 " +
                    "WHERE id_comision=@id", sqlConnection);
                cmdDelete.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = ID;
                this.OpenConnection();
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e.InnerException;
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
                throw new Exception("Error en bd",e);
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
                SqlCommand cmd = new SqlCommand("sp_add_comisiones2", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@d_com",com.Descripcion);  //(@d_com,@id_com,@anio,@id_plan,
                cmd.Parameters.AddWithValue("@anio", com.AnioEspecialidad);

                this.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
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


