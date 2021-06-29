using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    class EspecialidadAdapter
    {
        #region DatosEnMemoria
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Especialidad> _Especialidad;

        private static List<Especialidad> Especialidades
        {
            get
            {
                if (_Especialidad == null)
                {
                    _Especialidad = new List<Business.Entities.Especialidad>();
                    Business.Entities.Especialidad esp;
                    esp = new Business.Entities.Especialidad();
                    esp.ID = 1;
                    esp.State = Business.Entities.BusinessEntity.States.Unmodified;
                    esp.Descripcion = "Ingenieria en Sistemas de Informacion";
                    _Especialidad.Add(esp);

                    esp = new Business.Entities.Especialidad();
                    esp.ID = 2;
                    esp.State = Business.Entities.BusinessEntity.States.Unmodified;
                    esp.Descripcion = "Ingenieria Quimica";
                    _Especialidad.Add(esp);

                    esp = new Business.Entities.Especialidad();
                    esp.ID = 3;
                    esp.State = Business.Entities.BusinessEntity.States.Unmodified;
                    esp.Descripcion = "Ingenieria Civil";
                    _Especialidad.Add(esp);

                    esp = new Business.Entities.Especialidad();
                    esp.ID = 4;
                    esp.State = Business.Entities.BusinessEntity.States.Unmodified;
                    esp.Descripcion = "Ingenieria Electrica";
                    _Especialidad.Add(esp);



                }
                return _Especialidad;
            }
        }
        #endregion

        public List<Especialidad> GetAll()
        {
            return new List<Especialidad>(Especialidades);
        }

        public Business.Entities.Especialidad GetOne(int ID)
        {
            return Especialidades.Find(delegate (Especialidad e) { return e.ID == ID; });
        }

        public void Delete(int ID)
        {
            Especialidades.Remove(this.GetOne(ID));
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Especialidad esp in Especialidades)
                {
                    if (esp.ID > NextID)
                    {
                        NextID = esp.ID;
                    }
                }
                especialidad.ID = NextID + 1;
                Especialidades.Add(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                Especialidades[Especialidades.FindIndex(delegate (Especialidad e) { return e.ID == especialidad.ID; })] = especialidad;
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }
    }
}

