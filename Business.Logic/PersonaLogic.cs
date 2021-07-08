using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class PersonaLogic: BusinessLogic
    {
        public PersonaLogic()
        {
            this.Persona_data = new PersonaAdapter();
        }

        private PersonaAdapter _perAdpt;
        public PersonaAdapter Persona_data
        {
            get { return this._perAdpt; }
            set { this._perAdpt = value; }
        }

        public List<Persona> Personas
        {
            get 
            {
                return this.Persona_data.GetAll();
            }
        }

        public void AddNew(Persona per)
        {
            foreach(Persona p in this.Personas)
            {
                if (p.Email==per.Email)
                {
                    //error no manejado
                    throw new Exception("Persona ya existente!"); // devuelve excepcion porque ya existe una persona con ese mail
                }
            }
            this.Persona_data.AddNew(per);
            
            
            this.Persona_data.AddNew(per);
        }

        public List<Persona> GetAll()
        {
            return this.Personas;
        }
    }
}
