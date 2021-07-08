using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        //contructor para crear instancia de entidad con datos pre existente
        //se usa con base(int)
        public BusinessEntity(int id)
        {
            this.ID = id;
            this.State = States.Unmodified;
        }

        //constructor para crear nueva instancia de alguna entidad
        public BusinessEntity()
        {
            this.State = States.New;
        } 

        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private States _State;
        public States State
        {
            get { return _State; }
            set { _State = value; }
        }
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified,
        }

    }
}
