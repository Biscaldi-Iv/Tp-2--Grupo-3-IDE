using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.Data.SqlClient;

namespace Data.Database
{
    public class MateriasAdapter: Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_materia], [desc_materia], [hs_semanales]," +
                " [hs_totales], [id_plan] FROM [Academia].[dbo].[materias]");
            while(reader.Read())
            {
                Materia mat = new Materia(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3),
                    reader.GetInt32(4));
                materias.Add(mat);
            }
            reader.Close();
            this.CloseConnection();

            return materias;
              
        }

        public Materia GetOne(int id)
        {
            this.OpenConnection();
            SqlDataReader reader= this.ExecuteReader("SELECT [id_materia], [desc_materia], [hs_semanales]," +
                " [hs_totales], [id_plan] FROM [Academia][dbo].[materias] " +
                $"WHERE [id_materia]={id}");
            reader.Read();
            Materia mat = new Materia(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3),
                    reader.GetInt32(4));
            reader.Close();
            this.CloseConnection();

            return mat;
        }

        public void AddNew(Materia mat)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Academia].[dbo].[materias] " +
                        "([desc_materia], [hs_semanales], [hs_totales], [id_plan]) " +
                        "VALUES " +
                        "(@desc, @hs_sem, @hs_tot, @plan)", sqlConnection);
                cmd.Parameters.Add("@desc", System.Data.SqlDbType.VarChar, 50).Value = mat.Descripcion;
                cmd.Parameters.Add("@hs_sem", System.Data.SqlDbType.Int).Value = mat.HsSemanales;
                cmd.Parameters.Add("@hs_tot", System.Data.SqlDbType.Int).Value = mat.HsTotales;
                cmd.Parameters.Add("@plan", System.Data.SqlDbType.Int).Value = mat.IDPlan;

                this.OpenConnection();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void SaveChanges(Materia mat)
        {
            try
            {
                SqlCommand cmdsave = new SqlCommand("UPDATE materias SET " +
                        "desc_materia= @desc," +
                        "hs_semanales= @hs_sem, " +
                        "hs_totales= @hs_tot, " +
                        "id_plan= @plan " +
                        "WHERE id_materia=@id ", sqlConnection);
                cmdsave.Parameters.Add("@desc", System.Data.SqlDbType.VarChar, 50).Value = mat.Descripcion;
                cmdsave.Parameters.Add("@hs_sem", System.Data.SqlDbType.Int).Value = mat.HsSemanales;
                cmdsave.Parameters.Add("@hs_tot", System.Data.SqlDbType.Int).Value = mat.HsTotales;
                cmdsave.Parameters.Add("@plan", System.Data.SqlDbType.Int).Value = mat.IDPlan;
                cmdsave.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = mat.ID;

                this.OpenConnection();

                cmdsave.ExecuteNonQuery();
            }
            catch (SqlException sqle)
            {
                throw sqle.InnerException;
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
                SqlCommand cmdDelete = new SqlCommand("DELETE materias FROM materias WHERE id_materia= @id", sqlConnection);
                cmdDelete.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                this.OpenConnection();
                cmdDelete.ExecuteNonQuery();

            }
            catch (SqlException sqle)
            {
                throw sqle.InnerException;
            }
            finally
            {
                this.CloseConnection();
            }
        }


    }
}
