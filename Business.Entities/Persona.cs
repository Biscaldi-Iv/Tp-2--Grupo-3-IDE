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
        private TipoPersonas _TipoPersona;

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
        
        public DateTime FechaNacimiento
        {
            get { return this._FechaNacimiento; }
            set { this._FechaNacimiento = value; }
        }

        public int IDPlan
        {
            get { return this._IDPlan; }
            set { this._IDPlan = value; }
        }

        public int Legajo
        {
            get { return this._Legajo; }
            set { this._Legajo = value; }
        }

        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        public string Telefono
        {
            get { return this._Telefono; }
            set { this._Telefono = value; }
        }

        // Corregir si es necesario creando 2 propiedades: getTipo y setTipo
        public string TipoPersona
        {
            get { return this._TipoPersona.Descripcion; }
            set { this._TipoPersona.Descripcion = value; }
        }
    }
}
