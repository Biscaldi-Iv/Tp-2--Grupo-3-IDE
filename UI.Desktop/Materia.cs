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

namespace UI.Desktop
{
    public partial class Materia : ApplicationForm
    {
        public Materia()
        {
            InitializeComponent();
            this.Materias = new MateriasLogic();
            this.Listar();
        }

        private MateriasLogic _materiasLogic;
        public MateriasLogic Materias
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
                this.dgvMateria.DataSource = this.Materias.GetAll();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

        }

        private void Materia_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
