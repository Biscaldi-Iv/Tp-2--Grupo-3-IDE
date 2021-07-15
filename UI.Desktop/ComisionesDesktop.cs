using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class ComisionesDesktop : ApplicationForm
    {
        private Comision _comisionActual;
        public Comision ComisionActual
        {
            get => this._comisionActual;
            set { this._comisionActual = value; }
        }
        public ComisionesDesktop() 
        {
            InitializeComponent();
        }
        public ComisionesDesktop(ModoForm modo) : this()  // constructor para altas
        {
            Modo = modo;
            //falta ver el modo en que entra y setear el texto del boton aceptar/guardar/baja segun sea necesario
            Comision com = new Comision(0,0,0,"");
            ComisionActual = com;
            MapearDeDatos();
        }

        //ctr para modif/bajas
        public ComisionesDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            ComisionLogic comL = new ComisionLogic();  
            this.ComisionActual = comL.GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            this.comboBoxPlan.DataSource = new PlanesLogic().GetAll();
            this.txtIDCom.ReadOnly = true;
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        this.txtIDCom.Text = "*";
                        this.btnAceptar.Text = "Registrar";
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.btnAceptar.Text = "Guardar";
                        this.txtIDCom.Text = this.ComisionActual.ID.ToString();
                        this.txtDesc.Text = this.ComisionActual.Descripcion;
                        this.txt_anio_Esp.Text = this.ComisionActual.AnioEspecialidad.ToString();
                        this.comboBoxPlan.SelectedItem = this.ComisionActual.IDPlan;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.txtDesc.ReadOnly = true;
                        this.txt_anio_Esp.ReadOnly = true;
                        this.txtIDCom.ReadOnly = true;
                        this.comboBoxPlan.Enabled = false;
                        this.btnAceptar.Text = "Eliminar";
                        this.txtIDCom.Text = this.ComisionActual.ID.ToString();
                        this.txtIDCom.Text = this.ComisionActual.Descripcion;
                        this.txt_anio_Esp.Text = this.ComisionActual.AnioEspecialidad.ToString();
                        this.comboBoxPlan.SelectedItem = this.ComisionActual.IDPlan;
                        break;
                    }
            }
        }

        public override void MapearADatos()
        {
            this.ComisionActual.Descripcion = this.txtDesc.Text;
            this.ComisionActual.IDPlan = new PlanesLogic().GetByDesc(this.comboBoxPlan.Text).ID;
            this.ComisionActual.AnioEspecialidad= Convert.ToInt32(this.txt_anio_Esp.Text);
        }


        public override bool Validar() { return false; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ComisionLogic comL = new ComisionLogic();
            MapearADatos();
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        try
                        {
                            comL.AddNew(ComisionActual);
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
                            comL.SaveChanges(ComisionActual);
                        }
                        catch (Exception ex)
                        {
                            Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case ModoForm.Baja:
                    {
                       comL.Delete(Convert.ToInt32(this.txtIDCom.Text));
                        break;
                    }
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

