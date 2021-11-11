using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        public UsuarioLogic()
            {
            this.UsuarioData = new UsuarioAdapter();
            }

        private Data.Database.UsuarioAdapter _UsuarioData;
        public Data.Database.UsuarioAdapter UsuarioData
        {
            get {return this._UsuarioData; }
            set { this._UsuarioData = value; }
        }

        private List<Usuario> usuarios;

        public List<Usuario> Usuarios
        {
            get
            {
                if (usuarios == null)
                {
                    usuarios = this.GetAll();
                }
                return usuarios;
            }
        }


        public List<Usuario> GetAll() 
        {
            return this.UsuarioData.GetAll();
        }

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public void Delete(int id)
        {
            this.UsuarioData.Delete(id);
        }

        public void Save(Usuario usr)
        {
            this.UsuarioData.SaveChanges(usr);
        }

        public bool VerificarUsuario(string nu, string pas)
        {
            try
            {
                var usr = from usuario in this.Usuarios where usuario.NombreUsuario == nu && usuario.Clave == pas select usuario;
                if (usr.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception exc)
            {
                throw new Exception("Error en bd");
            }

        }

        public Usuario RecuperarUsuario(string nu, string pas)
        {
            var usr = from usuario in this.Usuarios where usuario.NombreUsuario == nu && usuario.Clave == pas select usuario;
            return usr.First();
        }

        public void AddNew(Usuario usr)
        {
            UsuarioData.AddNew(usr);
        }
        
    }
}
