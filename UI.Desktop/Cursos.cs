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

namespace UI.Desktop
{
    public partial class Cursos : ApplicationForm
    {
        private CursosLogic cl;
        
        public Cursos()
        {
            InitializeComponent();
            this.cl = new CursosLogic();
            this.Listar();
        }

        public void Listar()
        {
            this.dgvCursos.AutoGenerateColumns = false;
            try
            {
                this.dgvCursos.DataSource = cl.getAll();
            }
            catch (Exception e)
            {
                Notificar("Error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
