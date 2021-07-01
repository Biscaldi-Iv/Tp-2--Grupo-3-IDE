using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using Microsoft.Data.SqlClient;

namespace Data.Database
{
    public class UsuarioAdapter:Adapter
    {
        #region DatosEnMemoria
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Usuario> _Usuarios;

        private List<Usuario> Usuarios
        {
            get
            {
                if (_Usuarios == null)
                {
                    _Usuarios = this.GetAll();
                }
                return _Usuarios;
            }
        }
        #endregion

        #region base_datos
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
                    reader.GetBoolean(3));
                users.Add(usr);
            }
            reader.Close();
            this.CloseConnection();
            return users;
        }
        #endregion

        public Business.Entities.Usuario GetOne(int ID)
        {
            this.OpenConnection();
            SqlDataReader reader = this.ExecuteReader("SELECT [id_usuario],[nombre_usuario],[clave]," +
                "[nombre],[apellido],[email],[habilitado] " +
                "FROM[Academia].[dbo].[usuarios]" +
                $"WHERE [id_usuario]={ID}");
            reader.Read();
            Usuario u = new Usuario(reader.GetInt32(0) ,reader.GetString(1), reader.GetString(2), reader.GetString(3),
                reader.GetString(4), reader.GetString(5), reader.GetBoolean(6));
            reader.Close();
            this.CloseConnection();

            return u;
        }

        public void Delete(int ID)
        {
            Usuarios.Remove(this.GetOne(ID));
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Usuario usr in Usuarios)
                {
                    if (usr.ID > NextID)
                    {
                        NextID = usr.ID;
                    }
                }
                usuario.ID = NextID + 1;
                Usuarios.Add(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                Usuarios[Usuarios.FindIndex(delegate(Usuario u) { return u.ID == usuario.ID; })]=usuario;
            }
            usuario.State = BusinessEntity.States.Unmodified;            
        }

        
    }
}
