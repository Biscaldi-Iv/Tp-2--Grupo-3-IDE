using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class DocentesCursosLogic
    {
        public DocentesCursosAdapter Source { get; set; }
        public DocentesCursosLogic()
        {
            Source = new DocentesCursosAdapter();
        }
        public List<DocenteCurso> GetDocentesCursos()
        {
            try
            {
                List<DocenteCurso> dc = Source.GetDocentesCursos();
                return dc;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
