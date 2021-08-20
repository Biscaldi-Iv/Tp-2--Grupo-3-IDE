using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso: BusinessEntity
    {
        private int _AnioCalendario,_Cupo;
        private string _Descripcion;
        private int _IDComision, _IDMateria;

        public Curso(int id, int idmat, int idcom, int cale, int cupo, string desc) : base(id)
        {
            this.IDMateria = idmat;
            this.IDComision = idcom;
            this.AnioCalendario = cale;
            this.Cupo = cupo;
            this.Descripcion = desc;
        }

        public int AnioCalendario
        {
            get { return this._AnioCalendario; }
            set { this._AnioCalendario = value; }
        }

        public int Cupo
        {
            get { return this._Cupo; }
            set { this._Cupo = value; }
        }

        public string Descripcion
        {
            get { return this._Descripcion; }
            set { this._Descripcion = value; }
        }

        public int IDComision
        {
            get { return this._IDComision; }
            set { this._IDComision = value; }
        }

        public int IDMateria
        {
            get { return this._IDMateria; }
            set { this._IDMateria = value; }
        }
    }
}
