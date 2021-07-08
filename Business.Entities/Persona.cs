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
        private int _TipoPersona;

        public Persona (int id, string nom, string ap, string dir, string email, string tel, DateTime date, int leg, int tipo_per, int id_plan)
        {
            this.ID = id;
            this.Nombre = nom;
            this.Apellido = ap;
            this.Direccion = dir;
            this.Email = email;
            this.Telefono = tel;
            this.FechaNacimiento = date;
            this.Legajo = leg;
            this.TipoPersona = tipo_per;
            this.IDPlan = id_plan;
                
        }
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
        public int TipoPersona
        {
            get { return this._TipoPersona; }
            set { this._TipoPersona = value; }
        }
    }
}
