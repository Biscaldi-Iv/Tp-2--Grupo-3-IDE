using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using Microsoft.Data.SqlClient;

namespace Business.Logic
{
    public class EspecialidadLogic: BusinessLogic
    {
        public EspecialidadLogic()
        {
            this.Especialidad_data = new EspecialidadAdapter();
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
                throw new Exception(e.Message);
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
                throw new Exception(e.Message);
            }
        }

        public Especialidad GetByDesc(string des)
        {
            try
            {
                return Especialidad_data.GetByDesc(des);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void SaveChanges(Especialidad esp)
        {
            foreach (Especialidad e in Especialidades)
            {
                if (e.Descripcion == esp.Descripcion)
                {
                    throw new Exception("Ya existe una especialidad con el mismo nombre!"); // devuelve excepcion porque ya existe una especialidad con ese nombre
                }
            }
            try
            {
                Especialidad_data.SaveChanges(esp);
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
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

        public void Delete(int id_)
        {
            try
            {
                Especialidad_data.Delete(id_);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
