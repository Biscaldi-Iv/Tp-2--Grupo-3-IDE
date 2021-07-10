using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class PlanesDesktop : ApplicationForm
    {
        public PlanesDesktop()
        {
            InitializeComponent();
            EspecialidadLogic espl = new EspecialidadLogic();
            this.cbEspecialidades.DataSource = espl.GetAll();
        }

        //constructor de altas
        public PlanesDesktop(ModoForm modo):this()
        {
            Modo = modo;
            Plan p = new Plan(0,"",0);
            PlanActual = p;
            MapearDeDatos();
        }

        //ctr para modif
        public PlanesDesktop(int Id, ModoForm modo) : this()
        {
            Modo = modo;
            PlanesLogic pL = new PlanesLogic();
            this.PlanActual = pL.GetOne(Id);
            MapearDeDatos();
        }

        private Plan _PlanActual;
        public Plan PlanActual
        {
            get =>  this._PlanActual;
            set => _PlanActual = value;
        }

        public override void MapearDeDatos()
        {
            
            switch(Modo)
            {
                case ModoForm.Alta: 
                    {
                        this.btnGuardar.Text = "Registrar";
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.btnGuardar.Text = "Guardar";
                        this.txtBDesc_Plan.Text = PlanActual.Descripcion;
                        break;
                    }
                case ModoForm.Baja: 
                    {
                        this.cbEspecialidades.Enabled = false;
                        this.btnGuardar.Text = "Eliminar";
                        break;
                    }
            }
            this.tbID.Text = this.PlanActual.ID.ToString();
            this.txtBDesc_Plan.Text = this.PlanActual.Descripcion;
        }

        public override void MapearPersona()
        {
            this.PlanActual.ID = Convert.ToInt32(this.tbID.Text);
            this.PlanActual.Descripcion = this.txtBDesc_Plan.Text;
            EspecialidadLogic esl = new EspecialidadLogic();


            this.PlanActual.IDEspecialidad = esl.GetByDesc(this.cbEspecialidades.Text).ID;
            //
            //PlanesLogic pl = new PlanesLogic();
            //this.PlanActual.IDEspecialidad = pl.GetByDesc(this.cbEspecialidades.Text).ID;
            //error
        }

        private void GuardarMapeoADatos()
        {

        }

        public override void GuardarCambios()
        {

        }

        public override bool Validar()
        {
            return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PlanesLogic pL = new PlanesLogic();
            MapearPersona();
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        pL.AddNew(PlanActual);
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        pL.SaveChanges(PlanActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        pL.Delete(this.PlanActual.ID);
                        break;
                    }
            }
            this.Close();
        }
    }
}
