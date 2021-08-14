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
    public partial class Materias : ApplicationForm
    {
        public Materias()
        {
            InitializeComponent();
            this.MateriasL = new MateriasLogic();
            this.Listar();
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
