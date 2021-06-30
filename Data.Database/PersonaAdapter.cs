using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
namespace Data.Database
{
    class PersonaAdapter
    {
        #region DatosEnMemoria
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Persona> _Personas;

        private static List<Persona> Personas
        {
            get
            {
                if (_Personas == null)
                {
                    _Personas = new List<Business.Entities.Persona>();
                    Business.Entities.Persona per;
                    per = new Business.Entities.Persona();
                    per.ID = 1;
                    per.State = Business.Entities.BusinessEntity.States.Unmodified;
                    per.Nombre = "Casimiro";
                    per.Apellido = "Cegado";
                    per.Email = "casimirocegado@gmail.com";
                    per.Direccion = "av.Pellegrini 1000";
                    per.IDPlan = 1;
                    per.FechaNacimiento = new DateTime(1990 / 06 / 20);
                    per.Telefono ="10000";
                    per.Legajo = 10;

                    _Personas.Add(per);

                    per = new Business.Entities.Persona();
                    per.ID = 2;
                    per.State = Business.Entities.BusinessEntity.States.Unmodified;
                    per.Nombre = "Armando Esteban";
                    per.Apellido = "Quito";
                    per.FechaNacimiento = new DateTime(2000, 03, 15);
                    per.Telefono = "20000";
                    per.Email = "armandoquito@gmail.com";
                    per.Legajo = 20;
                    per.IDPlan = 1;
                    _Personas.Add(per);

                    per = new Business.Entities.Persona();
                    per.ID = 3;
                    per.State = Business.Entities.BusinessEntity.States.Unmodified;
                    per.Nombre = "Alan";
                    per.Apellido = "Brado";
                    per.Telefono = "30000";
                    per.IDPlan = 2;
                    per.Email = "alanbrado@gmail.com";
                    per.Legajo = 30;
                    _Personas.Add(per);

                }
                return _Personas;
            }
        }
        #endregion

        public List<Persona> GetAll()
        {
            return new List<Persona>(Personas);
        }

        public Business.Entities.Persona GetOne(int ID)
        {
            return Personas.Find(delegate (Persona p) { return p.ID == ID; });
        }

        public void Delete(int ID)
        {
            Persona.Remove(this.GetOne(ID));
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Persona usr in Personas)
                {
                    if (usr.ID > NextID)
                    {
                        NextID = usr.ID;
                    }
                }
                persona.ID = NextID + 1;
                Personas.Add(persona);
            }
            else if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                Personas[Personas.FindIndex(delegate (Persona p) { return p.ID == ; })] = persona;
            }
            persona.State = BusinessEntity.States.Unmodified;
        }
    }
}

