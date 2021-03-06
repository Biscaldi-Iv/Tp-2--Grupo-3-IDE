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
using Microsoft.Win32;

namespace UI.Desktop
{
    public partial class Comisiones : ApplicationForm
    {
        private ComisionLogic _comisiones;
         public Comisiones()
         {
             InitializeComponent();
             this.oComision = new ComisionLogic();
             this.dgvComisiones.AutoGenerateColumns = false;
             this.dgvComisiones.DataSource = this.oComision.GetAll();
             LoadTheme();
             UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
             SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
             this.Disposed += new EventHandler(Form_Disposed);
        }
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            }
        }

        private void LoadTheme()
        {
            var themeColor = WinTema.GetAccentColor();
            tcComisiones.TopToolStripPanel.BackColor = themeColor;
            tscComisiones.BackColor = themeColor;            
        }
        public void Listar()
        {
            ComisionLogic com = new ComisionLogic();
            try
            {
                this.dgvComisiones.DataSource = com.GetAll();
            }
            catch (Exception e) { Notificar("SQL error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        public ComisionLogic oComision
        {
            get { return _comisiones; }
            set { this._comisiones = value; }
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            Listar();
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.dgvComisiones.DataSource = this.oComision.GetAll();
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Listar();
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
            this.Listar();
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id_ = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionesDesktop com = new ComisionesDesktop(id_, ApplicationForm.ModoForm.Modificacion);
            com.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id_ = ((Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            ComisionesDesktop com = new ComisionesDesktop(id_, ApplicationForm.ModoForm.Baja);
            com.ShowDialog();
            this.Listar();
        }
    }

}
