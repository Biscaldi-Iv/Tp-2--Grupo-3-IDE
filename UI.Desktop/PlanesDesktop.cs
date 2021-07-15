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
                        this.txtD.Text = this.PlanActual.ID.ToString();
                        this.cbEspecialidades.SelectedValue = this.PlanActual.IDEspecialidad;
                        break;
                    }
                case ModoForm.Baja: 
                    {
                        this.cbEspecialidades.Enabled = false;
                        this.btnGuardar.Text = "Eliminar";
                        break;
                    }
            }
            this.txtD.Text = this.PlanActual.ID.ToString();
            this.txtBDesc_Plan.Text = this.PlanActual.Descripcion;
        }

        public override void MapearADatos()
        {
            this.PlanActual.ID = Convert.ToInt32(this.txtD.Text);
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
            MapearADatos();
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        try
                        {
                            pL.AddNew(PlanActual);
                        }
                        catch (Exception ex)
                        {
                            Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        try
                        {
                            pL.SaveChanges(PlanActual);
                        }
                        catch (Exception ex)
                        {
                            Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case ModoForm.Baja:
                    {
                        if (MessageBox.Show("Esta seguro que desea eliminar este plan?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                        {
                            try
                            {
                                pL.Delete(this.PlanActual.ID);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("No es posible eliminar este plan porque actualmente esta en uso", "Error", MessageBoxButtons.OK);
                            } 
                        }
                        break;
                    }
            }
            this.Close();
        }
    }
}
