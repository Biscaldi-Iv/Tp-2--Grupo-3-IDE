using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class EspecialidadLogic: BusinessLogic
    {
        public EspecialidadLogic(EspecialidadAdapter adapt)
        {
            this.Especialidad_data = adapt;
        }

        private List<Especialidad> _especialidades;

        private List<Especialidad> Especialidades
        {
            get
            {
                if (_especialidades == null)
                {
                    _especialidades = this.GetAll();
                }
                return _especialidades;
            }
        }

        private EspecialidadAdapter _Especialidad_data;

        public EspecialidadAdapter Especialidad_data
        {
            get => this._Especialidad_data;
            set => this._Especialidad_data = value;
        }

        public List<Especialidad> GetAll()
        {
            try
            {
                return Especialidad_data.GetAll();
            }
            catch(Exception e)
            {
                throw e.InnerException;
            }
        }

        public Especialidad GetOne(int id)
        {
            try
            {
                return Especialidad_data.GetOne(id);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void AddNew(Especialidad esp)
        {
            
            foreach (Especialidad e in Especialidades)
            {
                if (e.Descripcion == esp.Descripcion)
                {
                    throw new Exception("Especialidad ya existente!"); // devuelve excepcion porque ya existe una especialidad con ese nombre
                }
            }
            Especialidad_data.AddNew(esp);
           
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}
