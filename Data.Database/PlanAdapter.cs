using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;


namespace Data.Database
{
    public class PlanAdapter: Adapter
    {
        #region DatosEnMemoria
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Plan> _Plan;

        public PlanAdapter():base()
        {
            
        }

        private static List<Plan> Planes
        {
            get
            {
                if (_Plan == null)
                {
                    _Plan = new List<Business.Entities.Plan>();
                    Business.Entities.Plan pln;
                    pln = new Business.Entities.Plan();
                    pln.ID = 1;
                    pln.Descripcion = "2008";
                    pln.State = Business.Entities.BusinessEntity.States.Unmodified;
                    pln.IDEspecialidad = 1;
                    _Plan.Add(pln);

                    pln = new Business.Entities.Plan();
                    pln.ID = 2;
                    pln.Descripcion = "1998";
                    pln.State = Business.Entities.BusinessEntity.States.Unmodified;
                    pln.IDEspecialidad = 4;
                    _Plan.Add(pln);

                    
                    pln = new Business.Entities.Plan();
                    pln.ID = 3;
                    pln.Descripcion = "1960";
                    pln.State = Business.Entities.BusinessEntity.States.Unmodified;
                    pln.IDEspecialidad = 2;
                    _Plan.Add(pln);

                    pln = new Business.Entities.Plan();
                    pln.ID = 4;
                    pln.Descripcion = "2008";
                    pln.State = Business.Entities.BusinessEntity.States.Unmodified;
                    pln.IDEspecialidad = 3;
                    _Plan.Add(pln);

                }
                return _Plan;
            }
        }
        #endregion

        public List<Plan> GetAll()
        {
            return new List<Plan>(Planes);
        }

        public Business.Entities.Plan GetOne(int ID)
        {
            return Planes.Find(delegate (Plan p) { return p.ID == ID; });
        }

        public void Delete(int ID)
        {
            Planes.Remove(this.GetOne(ID));
        }

        public void SaveChanges(Plan plan)
        {
            if (plan.State == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Plan pln in Planes)
                {
                    if (pln.ID > NextID)
                    {
                        NextID = pln.ID;
                    }
                }
                plan.ID = NextID + 1;
                Planes.Add(plan);
            }
            else if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                Planes[Planes.FindIndex(delegate (Plan p) { return p.ID == plan.ID; })] = plan;
            }
            plan.State = BusinessEntity.States.Unmodified;
        }
    }
}

