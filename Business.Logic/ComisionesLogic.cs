using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
using Microsoft.Data.SqlClient;

namespace Business.Logic
{
    
        public class ComisionLogic : BusinessLogic
        {
            public ComisionLogic()
            {
                this.Comision_data = new ComisionAdapter();
            }

            private List<Comision> _comisiones;

            private List<Comision> Comisiones
            {
                get
                {
                    if (_comisiones == null)
                    {
                        _comisiones = this.GetAll();
                    }
                    return _comisiones;
                }
            }

            private ComisionAdapter _Comision_data;

            public ComisionAdapter Comision_data
            {
                get => this._Comision_data;
                set => this._Comision_data = value;
            }

            public List<Comision> GetAll()
            {
                try
                {
                    return Comision_data.GetAll();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            public Comision GetOne(int id)
            {
                try
                {
                    return Comision_data.GetOne(id);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            public void SaveChanges(Comision c)
            {
                try
                {
                    Comision_data.SaveChanges(c);
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public void AddNew(Comision com)
            {

                foreach (Comision c in Comisiones)
                {
                    if (c.Descripcion == com.Descripcion)
                    {
                        //error no manejado
                        throw new Exception("Especialidad ya existente!"); // devuelve excepcion porque ya existe una especialidad con ese nombre
                    }
                }
                Comision_data.AddNew(com);

            }

            public void Delete(int id_)
            {
                Comision_data.Delete(id_);
            }
        }
}
