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
<<<<<<< HEAD:UI.Desktop/ListaEspecialidades.cs
    public partial class FormListaEspecialidades : ApplicationForm
=======
    public partial class Especialidades : Form
>>>>>>> 857e8b406b5e1e3aa206bbdcae3e16cb6025006c:UI.Desktop/Especialidades.cs
    {
        private EspecialidadLogic _especialidades;

        public Especialidades()
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
        }
    }
}
