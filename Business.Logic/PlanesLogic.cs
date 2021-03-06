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
    public class PlanesLogic : BusinessLogic
    {

        public PlanesLogic()
        {
            this.Planes_Data = new PlanesAdapter();

        }
        
        private PlanesAdapter _PlanesData;
        
        public PlanesAdapter Planes_Data
        {
            get => this._PlanesData;
            set => this._PlanesData = value;
        }
       
        private List<Plan> _planes;
        
        public List<Plan> Planes
        {
            get
            {
                if (_planes == null)
                {
                    _planes = this.GetAll();
                }
                return _planes;
            }
        }

        public List<Plan> GetAll()
        {
            try
            {
                return Planes_Data.GetAll();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Plan GetOne(int id)
        {
            try
            {
                return Planes_Data.GetOne(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Plan GetByDesc(string d)
        {
            try
            {
                return Planes_Data.GetByDesc(d);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void SaveChanges(Plan p)
        {
            foreach (Plan pl in Planes)
            {
                if (pl.Descripcion == p.Descripcion && pl.ID!=p.ID)
                {
                    throw new Exception("Logica: Ya existe un plan con el mismo nombre!"); // devuelve excepcion porque ya existe un plan con ese nombre
                }
            }
            try
            {
                Planes_Data.SaveChanges(p);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddNew(Plan pln)
        {

            foreach (Plan e in Planes)
            {
                if (e.Descripcion == pln.Descripcion)
                {
                    throw new Exception("Plan ya existente!"); // devuelve excepcion porque ya existe un plan con ese nombre
                }
            }
            Planes_Data.AddNew(pln);

        }

        public void Delete(int id)
        {
            try
            {
                Planes_Data.Delete(id);
            }
            catch (Exception e)
            {
                throw new Exception("Logica:"+e.Message);
            }
        }
    }
}
