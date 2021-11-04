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
        public List<Curso> getCursosInscripto(int idPlan, int idAlumno)
        {
            try
            {
                List<Curso> cursos=ai_adapter.getCursosInscripto(idPlan, idAlumno);
                return cursos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Curso> getCursosDisponibles(int idPlan,int idAlumno) // habria que filtrar por año actual a los cursos??? preguntar
        {
            CursosLogic cLogic = new CursosLogic();
            List<Curso> cursosInscriptos = ai_adapter.getCursosInscripto(idPlan, idAlumno);
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

        public void EliminarInscripcion()
        {
            //ver
        }


    }
}
