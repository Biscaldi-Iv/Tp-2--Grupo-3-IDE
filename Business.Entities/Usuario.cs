using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private string _NombreUsuario, _Clave, _Nombre, _Apellido, _Email;
        private bool _Habilitado;

        public Usuario(int id,string user_name, string pass,string nom, string appellido, string email, bool h ): base(id)
        { 
            this.NombreUsuario = user_name;
            this.Clave = pass;
            this.Apellido = appellido;
            this.Nombre = nom;
            this.Email = email;
            this.Habilitado = h;
        }

        public string NombreUsuario
        {
            get { return this._NombreUsuario; }
            set { this._NombreUsuario = value; }
        }

        public string Clave
        {
            get { return this._Clave; }
            set { this._Clave = value; }
        }

        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        public string Apellido
        {
            get { return this._Apellido; }
            set { this._Apellido = value; }
        }

        public string Email
        {
            get { return this._Email; }
            set { this._Email = value; }
        }

        public bool Habilitado
        {
            get { return this._Habilitado; }
            set { this._Habilitado = value; }
        }
    }
}
