using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class MateriasLogic : BusinessLogic
    {
        public MateriasLogic()
        {
            this.Materia_data = new MateriasAdapter();
        }

        private MateriasAdapter _matAdpt;
        public MateriasAdapter Materia_data
        {
            get { return this._matAdpt; }
            set { this._matAdpt = value; }
        }

        public List<Materia> materias;
        public List<Materia> Materias
        {
            get { return this.Materia_data.GetAll(); }
        }

        public List<Materia> GetAll()
        {
            return this.Materia_data.GetAll();
        }
        public Materia GetOne(int id)
        {
            return Materia_data.GetOne(id);
        }

        public void Delete(int id)
        {
            this.Materia_data.Delete(id);
        }
        public void Save(Materia mat)
        {
            this.Materia_data.SaveChanges(mat);
        }
        public void AddNew(Materia mat)
        {
            Materia_data.AddNew(mat);
        }

        public bool VerificarMateria(string desc)
        {
            try
            {
                var mat = from materia in this.Materias where materia.Descripcion == desc select materia;
                if(mat.Any())
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch(Exception exc)
            {
                throw new Exception("Error en bd"); //
            }
        }

    }
}
