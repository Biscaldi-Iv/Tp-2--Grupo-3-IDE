using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class TipoPersonaLogic : BusinessLogic
    {
        public TipoPersonaLogic()
        {
            this.TipoPersona_data = new TipoPersonaAdapter();
        }
        
        
        private TipoPersonaAdapter _TipoPersona_data;

        public TipoPersonaAdapter TipoPersona_data
        {
            get => this._TipoPersona_data;
            set => this._TipoPersona_data = value;
        }
        public TipoPersonas GetOne(int id)
        {
            try
            {
                return TipoPersona_data.GetOne(id);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
        public List<TipoPersonas> GetAll()
        {
            try
            {
                return TipoPersona_data.GetAll();
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
        public TipoPersonas GetByDesc(string des)
        {
            try
            {
                return TipoPersona_data.GetByDesc(des);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
    }
}
