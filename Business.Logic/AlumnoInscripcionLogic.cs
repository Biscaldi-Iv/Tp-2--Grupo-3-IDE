using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;

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

    }
}
