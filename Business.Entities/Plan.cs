using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        private string _Descripcion;
        public string Descripcion
        {
            get { return this._Descripcion; }
            set { this._Descripcion = value; }
        }


        private int _IDEspecialidad;
        public int IDEspecialidad
        {
            get { return this._IDEspecialidad; }
            set { this._IDEspecialidad = value; }
        }

        //constructor sin id para crear nuevos planes
        public Plan(string desc, int esp)
        {
            this.Descripcion = desc;
            this.IDEspecialidad = esp;
        }

        //constructor con id para instanciar con datos recuperados de base de datos
        public Plan(int idp, string desc, int esp)
        {
            this.ID = idp;
            this.Descripcion = desc;
            this.IDEspecialidad = esp;
        }
    }
}
