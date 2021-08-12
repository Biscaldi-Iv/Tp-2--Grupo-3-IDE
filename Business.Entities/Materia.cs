using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materia: BusinessEntity
    {
        private int _IDPlan,_HsSemanales, _HsTotales;
        private string _Descripcion;

        public Materia(int id, string desc, int hs_sem, int hs_tot, int id_plan) : base(id)
        {
            this.Descripcion = desc;
            this.HsSemanales = hs_sem;
            this.HsTotales = hs_tot;
            this.IDPlan = id_plan;
        }

        public int IDPlan
        {
            get { return this._IDPlan; }
            set { this._IDPlan = value; }
        }

        public int HsSemanales
        {
            get { return this._HsSemanales; }
            set { this._HsSemanales = value; }
        }

        public int HsTotales
        {
            get { return this._HsTotales; }
            set { this._HsTotales = value; }
        }

        public string Descripcion
        {
            get { return this._Descripcion; }
            set { this._Descripcion = value; }
        }
    }
}
