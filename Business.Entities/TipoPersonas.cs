using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class TipoPersonas: BusinessEntity
    {
        private string _Descripcion;

        public string Descripcion
        {
            get { return this._Descripcion; }
            set { this._Descripcion = value; }
        }

        public TipoPersonas(int id, string desc)
        {
            this.ID = id;
            this.Descripcion = desc;
        }
    }
}
