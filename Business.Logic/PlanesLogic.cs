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
                throw e.InnerException;
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
                throw e.InnerException;
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
                throw e.InnerException;
            }
        }

        public void SaveChanges(Plan e)
        {
            try
            {
                Planes_Data.SaveChanges(e);
            }
            catch (SqlException ex)
            {
                throw ex.InnerException;
            }
        }

        public void AddNew(Plan pln)
        {

            foreach (Plan e in Planes)
            {
                if (e.Descripcion == pln.Descripcion)
                {
                    //error no manejado
                    throw new Exception("Plan ya existente!"); // devuelve excepcion porque ya existe un plan con ese nombre
                }
            }
            Planes_Data.AddNew(pln);

        }

        public void Delete(int id)
        {
            Planes_Data.Delete(id);
        }
    }
}
