using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Persona: BusinessEntity
    {
        private string _Apellido, _Direccion, _Email;
        private DateTime _FechaNacimiento;
        private int _IDPlan, _Legajo;
        private string _Nombre, _Telefono;
        //private TipoPersona _TipoPersonas;

        public string Apellido
        {
            get { return this._Apellido; }
            set { this._Apellido = value; }
        }

        public string Direccion
        {
            get { return this._Direccion; }
            set { this._Direccion = value; }
        }

        public string Email
        {
            get { return this._Email; }
            set { this._Email = value; }
        }
    }
}
