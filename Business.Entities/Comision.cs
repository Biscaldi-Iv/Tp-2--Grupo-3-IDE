using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private int _AnioEspecialidad, _IDPlan;
        private string _Descripcion;

        public int AnioEspecialidad
        {
            get { return this._AnioEspecialidad; }
            set { this._AnioEspecialidad = value; }
        }

        public int IDPlan
        {
            get { return this._IDPlan; }
            set { this._IDPlan = value; }
        }

        public string Descripcion
        {
            get { return this._Descripcion; }
            set { this._Descripcion = value; }
        }
    }
}
