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
using Microsoft.Win32;

namespace UI.Desktop
{
    public partial class Planes : Form
    {
        private PlanesLogic _planesLogic;
        public PlanesLogic oPlan
        {
            get => this._planesLogic;
            set => this._planesLogic = value;
        }



        public Planes()
        {
            InitializeComponent();
            this.oPlan = new PlanesLogic();
            this.dgvPlanes.AutoGenerateColumns = false;
            this.dgvPlanes.DataSource = this.oPlan.GetAll();
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
            tcPlanes.TopToolStripPanel.BackColor = themeColor;
            tsPlanes.BackColor = themeColor;

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        public void Listar()
        {
            PlanesLogic p1 = new PlanesLogic();
            this.dgvPlanes.DataSource = p1.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPlanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Planes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tlPlanes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PlanesDesktop pld = new PlanesDesktop(ApplicationForm.ModoForm.Alta);
            pld.ShowDialog();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id_ = ((Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanesDesktop esp = new PlanesDesktop(id_, ApplicationForm.ModoForm.Modificacion);
            esp.ShowDialog();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id_ = ((Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanesDesktop esp = new PlanesDesktop(id_, ApplicationForm.ModoForm.Baja);
            esp.ShowDialog();
        }
    }
}
