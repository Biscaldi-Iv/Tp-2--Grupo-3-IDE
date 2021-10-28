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

    public partial class FormListaEspecialidades : ApplicationForm
    {
        private EspecialidadLogic _especialidades;

        public FormListaEspecialidades()
        {
            InitializeComponent();
            this.oEspecialidad = new EspecialidadLogic();
            this.dgvEspecialidades.AutoGenerateColumns = false;
            this.dgvEspecialidades.DataSource = this.oEspecialidad.GetAll();
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
            tscEspecialidades.TopToolStripPanel.BackColor = themeColor;
            toolStripEsp.BackColor = themeColor;

        }

        private void ListaEspecialidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            EspecialidadLogic esp = new EspecialidadLogic();
            try
            {
                this.dgvEspecialidades.DataSource = esp.GetAll();
            }catch(Exception e) { Notificar("error","sql roto", MessageBoxButtons.YesNo,MessageBoxIcon.Error); }
        }

        public EspecialidadLogic oEspecialidad
        {
            get { return _especialidades; }
            set { this._especialidades = value; }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           this.dgvEspecialidades.DataSource = this.oEspecialidad.GetAll();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadesDesktop esp = new EspecialidadesDesktop(ApplicationForm.ModoForm.Alta);
            esp.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id_ = ((Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadesDesktop esp = new EspecialidadesDesktop(id_,ApplicationForm.ModoForm.Modificacion);
            esp.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id_ = ((Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadesDesktop esp = new EspecialidadesDesktop(id_, ApplicationForm.ModoForm.Baja);
            esp.ShowDialog();
            this.Listar();
        }
    }
}
