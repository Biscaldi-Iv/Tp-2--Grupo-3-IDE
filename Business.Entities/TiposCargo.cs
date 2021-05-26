using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class TiposCargo: BusinessEntity
    {
        private string _TipoCargo;

        public string TipoCargo
        {
            get { return this._TipoCargo; }
            set { this._TipoCargo = value; }
        }
    }
}
