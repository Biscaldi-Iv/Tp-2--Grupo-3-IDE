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
            if(!this.VerificarExistencia(per.Email))
            {
                this.Persona_data.AddNew(per);
            }
            else
            {
                throw new Exception("Persona existente");
            }
        }

        public List<Persona> GetAll()
        {
            return this.Personas;
        }

        public int GetIDByMail(string mail)
        {
            return this.Persona_data.GetIDByMail(mail);
        }

        public bool VerificarExistencia(string email)
        {
            foreach (Persona p in this.Personas)
            {
                if (p.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
