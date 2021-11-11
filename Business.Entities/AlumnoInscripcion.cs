using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AlumnoInscripcion: BusinessEntity
    {
        private string _Condicion;
        private int _IDAlumno, _IDCurso, _Nota;

        public AlumnoInscripcion()
        {
        }

        public AlumnoInscripcion(int id, string condicion, int iDAlumno, int iDCurso, int nota)
        {
            ID = id;
            Condicion = condicion;
            IDAlumno = iDAlumno;
            IDCurso = iDCurso;
            Nota = nota;
        }

        
        public string Condicion
        {
            get { return this._Condicion; }
            set { this._Condicion = value; }
        }

        public int IDAlumno
        {
            get { return this._IDAlumno; }
            set { this._IDAlumno = value; }
        }

        public int IDCurso
        {
            get { return this._IDCurso; }
            set { this._IDCurso = value; }
        }

        public int Nota
        {
            get { return this._Nota; }
            set { this._Nota = value; }
        }
    }
}
