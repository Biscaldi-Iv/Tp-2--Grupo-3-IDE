
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class DocentesCursosForm : Form
    {
        public DocentesCursosForm()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            CursosLogic curso = new CursosLogic();
            PersonaLogic docente = new PersonaLogic();
            PlanesLogic plan = new PlanesLogic(); 
           
            this.cBoxDocente.DataSource = docente.GetDocentes();
            this.cBoxPlan.DataSource = plan.GetAll();            
            this.cBoxCurso.DataSource = curso.getCursobyIdPlan(Convert.ToInt32(this.cBoxPlan.SelectedValue));
        }

        private void cBoxPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CursosLogic curso = new CursosLogic();
            this.cBoxCurso.DataSource = curso.getCursobyIdPlan(Convert.ToInt32(this.cBoxPlan.SelectedValue));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /*
        Usar los Modos
        No mostrar ids nunca
        
        Los combo box de plan y curso solo deben ser modificables su seleccion en modo alta

        Los cambios de cbox plan deben afectar las opciones de los otros combo box

         */
    }
}
