using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CursosLogic
    {
        private List<Curso> _cursos;
        private List<Curso> Cursos
        {
            get
            {
                return new CursosAdapter().getAll();
            }
        }

        public Curso getOne(int id)
        {
            try
            {
                var c = from crs in this.Cursos where crs.ID == id select crs;
                return c.First();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Curso> getAll()
        {
            try
            {
                return Cursos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public void AddNew(Curso c)
        {
            try
            {
                if (Validaciones.ValidaCurso(c))
                {
                    new CursosAdapter().AddNew(c);
                }
                else
                {
                    throw new Exception("Curso ya existente!");
                }
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    
        public void Delete(int id)
        {
            try
            {
                new CursosAdapter().Delete(id); //faltan validaciones como no permitir borrar en caso de haber alumnos inscriptos(?)
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Save(Curso c)
        {
            try
            {
                if (Validaciones.ValidaCurso(c))
                {
                    new CursosAdapter().SaveChanges(c);
                }
                else
                {
                    throw new Exception("No se pudo modificar el curso porque ya existe uno similar!");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
