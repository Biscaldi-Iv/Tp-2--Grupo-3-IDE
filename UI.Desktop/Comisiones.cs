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
    public partial class Comisiones : Form
    {
        /* private ComisionesLogic _comisiones;
         public Comisiones()
         {
             InitializeComponent();
             this.oComisiones = new EspecialidadLogic();
             this.dgvComisiones.AutoGenerateColumns = false;
             this.dgvComisiones.DataSource = this.oComisiones.GetAll();
         }*/
        /* public void Listar()
         {
             ComisionesLogic cl = new ComisionesLogic();
             this.dgvComisiones.DataSource = cl.GetAll();
         }*/
        /*
        public ComisionLogic oComision
        {
            get { return _Comisiones; }
            set { this._Comisiones = value; }
        }*/

        private void Comisiones_Load(object sender, EventArgs e)
        {
           // Listar();
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //this.dgvComisiones.DataSource = this.oComision.GetAll();
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            //this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Program.menu.Show();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ComisionesDesktop com = new ComisionesDesktop(ApplicationForm.ModoForm.Alta);
            com.ShowDialog();
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id_ = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionesDesktop com = new ComisionesDesktop(id_, ApplicationForm.ModoForm.Modificacion);
            com.ShowDialog();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id_ = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionesDesktop esp = new ComisionesDesktop(id_, ApplicationForm.ModoForm.Baja);
            esp.ShowDialog();
        }
       /* public void Listar()
        {
            ComisionesLogic esp = new ComisionesLogic();
            try
            {
                this.dgvComisiones.DataSource = esp.GetAll();
            }
            catch (Exception e) { Notificar("error", "sql roto", MessageBoxButtons.YesNo, MessageBoxIcon.Error); }
        }*/
    }

}
