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
    public partial class Inscripciones : ApplicationForm
    {
        private CursosLogic cl;
        
        public Inscripciones(ModoForm modo)
        {
            InitializeComponent();
            this.Modo = modo;
            this.cl = new CursosLogic();
            this.Listar();

        }

        public void Listar()
        {
            this.dgvCursos.AutoGenerateColumns = false;
            switch(Modo)
            {
                //modo alta para inscribirse a materias
                case ModoForm.Alta:
                    {
                        this.dgvCursos.DataSource = this.cl.getCursosDisponibles(Program.plan.ID, Program.usuarioLog.IdPersona);
                        break;
                    }
                //modo consulta para ver las materias en las que se esta inscripto
                case ModoForm.Consulta:
                    {
                        //this.dgvCursos.DataSource = this.cl.getCursosInscripto(Program.plan.ID, Program.usuarioLog.IdPersona);
                        //this.dgvCursos.Columns.RemoveAt(2);
                        //generar columna nota
                        //ver si hay que unir 2 objetos usando linq e implementar alumnoinscriptcion en logic y adapter
                        break;
                    }
                //modo baja para eliminar la inscripcion
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Inscripcion a cursado", "Desea inscribirse a: " + ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).Descripcion,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.cl.Inscribirse(Program.usuarioLog.IdPersona ,((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID);
                this.Listar();
            }
        }
    }
}
