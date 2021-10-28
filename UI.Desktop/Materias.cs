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
    public partial class Materias : ApplicationForm
    {
        public Materias()
        {
            InitializeComponent();
            this.MateriasL = new MateriasLogic();
            this.Listar();
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
            toolStripContainer1.TopToolStripPanel.BackColor = themeColor;
            tsMateria.BackColor = themeColor;

        }

        private MateriasLogic _materiasLogic;
        public MateriasLogic MateriasL
        {
            get => this._materiasLogic;
            set
            {
                this._materiasLogic = value;
            }
        }

        public void Listar()
        {
            this.dgvMateria.AutoGenerateColumns = false;
            try
            {
                this.dgvMateria.DataSource = this.MateriasL.GetAll();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MateriaDesktop(ModoForm.Alta).ShowDialog();
            this.Show();
            this.Listar();
        }

        private void Materia_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            int _id = ((Materia)this.dgvMateria.SelectedRows[0].DataBoundItem).ID;
            new MateriaDesktop(_id, ModoForm.Modificacion).ShowDialog();
            this.Show();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            int _id = ((Materia)this.dgvMateria.SelectedRows[0].DataBoundItem).ID;
            new MateriaDesktop(_id, ModoForm.Baja).ShowDialog();
            this.Show();
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
