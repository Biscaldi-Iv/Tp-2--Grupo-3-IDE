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
    public partial class FormListaEspecialidades : Form
    {
        private EspecialidadLogic _especialidades;

        public FormListaEspecialidades()
        {
            InitializeComponent();
            this.oEspecialidad = new EspecialidadLogic();
            this.dgvEspecialidades.AutoGenerateColumns = false;
            this.dgvEspecialidades.DataSource = this.oEspecialidad.GetAll();
        }

        private void ListaEspecialidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            EspecialidadLogic esp = new EspecialidadLogic();
            this.dgvEspecialidades.DataSource = esp.GetAll();
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

    }
}
