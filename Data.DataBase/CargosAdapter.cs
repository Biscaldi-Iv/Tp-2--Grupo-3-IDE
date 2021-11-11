using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Microsoft.Data.SqlClient;

namespace Data.Database
{
    public class CargosAdapter : Adapter
    {
        public CargosAdapter() : base() { }

        public List<TiposCargo> getAll()
        {
            List<TiposCargo> tc = new List<TiposCargo>();
            tc.Add(new TiposCargo { ID = 1, TipoCargo = "Titular" });
            tc.Add(new TiposCargo { ID = 2, TipoCargo = "Suplente" });
            tc.Add(new TiposCargo { ID = 3, TipoCargo = "Director TP" });
            return tc;
        }

        public TiposCargo getOne(int id)
        {
            foreach (TiposCargo t in this.getAll())
            {
                if (id == t.ID)
                {
                    return t;
                }
            }
            return null;
        }
    }
}