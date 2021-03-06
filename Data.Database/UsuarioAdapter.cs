using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using Microsoft.Data.SqlClient;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        public UsuarioAdapter():base()
        {
            
        }

        public List<Usuario> GetAll()
        {
            this.OpenConnection();
            SqlDataReader reader= this.ExecuteReader("SELECT TOP (1000) [id_usuario],[nombre_usuario],[clave]," +
                "[habilitado],[nombre],[apellido],[email],[cambia_clave],[id_persona] " +
                "FROM[Academia].[dbo].[usuarios]");
            List<Usuario> users = new List<Usuario>();
            while (reader.Read()) 
            {
                Usuario usr = new Usuario(reader.GetInt32(0) ,reader.GetString(1), reader.GetString(2),
                    reader.GetString(4), reader.GetString(5), reader.GetString(6),
                    reader.GetBoolean(3),reader.GetInt32(8), reader.GetBoolean(7));
                users.Add(usr);
            }
            reader.Close();
            this.CloseConnection();
            return users;
        }

        public Business.Entities.Usuario GetOne(int ID)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_usuario],[nombre_usuario],[clave]," +
                "[nombre],[apellido],[email],[habilitado],[cambia_clave],[id_persona] " +
                "FROM[Academia].[dbo].[usuarios]" +
                $"WHERE [id_usuario]={ID}");
            reader.Read();
            Usuario u = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                reader.GetString(4), reader.GetString(5), reader.GetBoolean(6), reader.GetInt32(8), reader.GetBoolean(7)) ;
            reader.Close();
            this.CloseConnection();

            return u;
        }

        public void Delete(int ID)
        {
            try
            {
                SqlCommand cmdDelete = new SqlCommand(
                    "DELETE usuarios FROM " +
                    "usuarios " +
                    "WHERE id_usuario=@id", sqlConnection);
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

        public void SaveChanges(Usuario usuario)
        {
            try
            {
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE usuarios SET " +
                    "nombre_usuario=@n_user," +
                    "clave=@clave," +
                    "habilitado=@hab," +
                    "nombre=@nom," +
                    "apellido=@ape," +
                    "email=@email " +
                    ",[cambia_clave]=@ccl," +
                    "[id_persona]=@ide " +
                    "WHERE id_usuario=@id", sqlConnection);
                cmdSave.Parameters.Add("@n_user", System.Data.SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = usuario.ID;
                cmdSave.Parameters.Add("@clave", System.Data.SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@nom", System.Data.SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@ape", System.Data.SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSave.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 50).Value = usuario.Email;
                cmdSave.Parameters.Add("@hab", System.Data.SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@ccl", System.Data.SqlDbType.Bit).Value = usuario.CambiaContra;
                cmdSave.Parameters.Add("@ide", System.Data.SqlDbType.Int).Value = usuario.IdPersona;

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

        public void AddNew(Usuario usr) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_add_usuario", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom_usr", usr.NombreUsuario);
                cmd.Parameters.AddWithValue("@clave", usr.Clave);
                cmd.Parameters.AddWithValue("@habilitado", usr.Habilitado);
                cmd.Parameters.AddWithValue("@nombre", usr.Nombre);
                cmd.Parameters.AddWithValue("@apellido", usr.Apellido);
                cmd.Parameters.AddWithValue("@email",usr.Email);
                cmd.Parameters.AddWithValue("@cambia_pass", usr.CambiaContra);
                cmd.Parameters.AddWithValue("@id_pers",usr.IdPersona);
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
