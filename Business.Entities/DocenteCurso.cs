using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class DocenteCurso: BusinessEntity
    {
        //private TiposCargo _Cargo;
        private int _IDCurso, _IDDocente;

        /*public TipoCargo Cargo
        {
            get { return this._Cargo; }
            set { this._Cargo = value; }
        }*/

        public int IDCurso
        {
            get { return this._IDCurso; }
            set { this._IDCurso = value; }
        }

        public int IDDocente
        {
            get { return this._IDDocente; }
            set { this._IDDocente = value; }
        }
    }
}
