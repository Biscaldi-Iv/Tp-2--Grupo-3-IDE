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
            Comision com = new Comision();
            ComisionActual = com;
            MapearDeDatos();
        }
        public ComisionesDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            ComisionLogic comL = new ComisionLogic();  /// FALTA CREAR COM logic
            this.ComisionActual = comL.GetOne(Id);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        this.btnAceptar.Text = "Registrar";
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.txtDesc.ReadOnly = true;
                        this.txt_anio_Esp.ReadOnly = true;
                        this.btnAceptar.Text = "Eliminar";
                        break;
                    }
            }
            this.txtIDCom.Text = this.ComisionActual.ID.ToString();
            this.txtDesc.Text = this.ComisionActual.Descripcion;
            this.txtIDPlan.Text = this.ComisionActual.IDPlan.ToString();
            this.txt_anio_Esp.Text = this.ComisionActual.AnioEspecialidad.ToString() ;
        }

        public override void MapearADatos()
        {
            this.ComisionActual.ID = Convert.ToInt32(this.txtIDCom.Text);
            this.ComisionActual.Descripcion = this.txtDesc.Text;
            this.ComisionActual.IDPlan= Convert.ToInt32(this.txtIDPlan.Text);
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
                        comL.AddNew(ComisionActual);
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        comL.SaveChanges(ComisionActual;
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
}
