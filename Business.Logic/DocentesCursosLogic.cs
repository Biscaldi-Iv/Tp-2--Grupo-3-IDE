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

        public List<ValueTuple<DocenteCurso, Curso, Persona>> cursos_asignados()
        {
            PersonaLogic PersonasL = new PersonaLogic();
            CursosLogic CursosL = new CursosLogic();
            var cursos = CursosL.getAll();
            var docenteCursos = this.GetDocentesCursos();
            var docentes = PersonasL.GetDocentes();
            var cur_doc = (from dc in docenteCursos
                           join c in cursos on dc.IDCurso equals c.ID
                           join doc in docentes on dc.IDDocente equals doc.ID
                           select (dc, c, doc)).ToList();

            return cur_doc;
        }

        public List<TiposCargo> getAllcargos()
        {
            try
            {
                CargosAdapter tca = new CargosAdapter();
                List<TiposCargo> tc = tca.getAll();
                return tc;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public TiposCargo getOneCargo(int id)
        {
            CargosAdapter tca = new CargosAdapter();
            TiposCargo tc = tca.getOne(id);
            return tc;
        }

        public void AddNew(DocenteCurso docenteCursoActual)
        {
            try
            {
                Source.AddNew(docenteCursoActual);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
