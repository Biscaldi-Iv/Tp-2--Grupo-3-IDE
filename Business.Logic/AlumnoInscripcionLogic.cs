using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic : BusinessLogic
    {
        private AlumnoInscripcionAdapter ai_adapter;

        public AlumnoInscripcionLogic()
        {
            ai_adapter = new AlumnoInscripcionAdapter();
        }
        public void Inscribirse(int idAl, int idCurso)
        {
            try
            {
                ai_adapter.Inscribirse(idAl, idCurso);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public List<Entities.AlumnoInscripcion> getCursosInscripto(int idAlumno)
        {
            try
            {
                List<Entities.AlumnoInscripcion> ai = ai_adapter.getCursosInscripto(idAlumno);
                return ai;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Curso> getCursosDisponibles(int idPlan,int idAlumno) // habria que filtrar por año actual a los cursos??? preguntar
        {
            CursosLogic cLogic = new CursosLogic();
            List<Entities.AlumnoInscripcion> cursosInscriptos = ai_adapter.getCursosInscripto(idAlumno);
            List<Curso> cursosPlan = cLogic.getbyPlan(idPlan);
            //List<Curso> CursosDisp = (from cp in cursosPlan where !cursosInscriptos.Contains(cp) select cp).ToList();
            List<Curso> CursosDisp = new List<Curso>();
            foreach (Curso c in cursosPlan)
            {
               var bandera = (from cp in cursosInscriptos where cp.ID == c.ID select cp).ToList().Count(); // anda joya
                if (bandera == 0)
                {
                    CursosDisp.Add(c);
                }
                
            }
            return CursosDisp;
        }

        public void Save(AlumnoInscripcion alumnoActual)
        {
            try
            {
                this.ai_adapter.SaveChanges(alumnoActual);             
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EliminarInscripcion()
        {
            //ver
        }

        public List<Entities.AlumnoInscripcion> getAll()
        {
            try
            {
                List<Entities.AlumnoInscripcion> ai = ai_adapter.getAll();
                    return ai;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Entities.AlumnoInscripcion getOne(int idIns)
        {
            try
            {
                Entities.AlumnoInscripcion ai = ai_adapter.getOne(idIns);
                return ai;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<AlumnoInscripcion> GetInscripciones_D(int idDoc)
        {
            List<AlumnoInscripcion> ins = this.getAll();
            DocentesCursosLogic dcl = new DocentesCursosLogic();
            CursosLogic cl = new CursosLogic();
            List<Curso> cursos_del_doc = (from c in cl.getAll()
                                          join dc in dcl.GetDocentesCursos()
                   on c.ID equals dc.IDCurso
                                          where
                dc.IDDocente == idDoc
                                          select c).ToList();
            List<AlumnoInscripcion> ins_del_doc = (from i in ins
                                                   join c in cursos_del_doc
                                    on i.IDCurso equals c.ID
                                                   select i).ToList();
            return ins_del_doc;
                                    
        }
    }
}
