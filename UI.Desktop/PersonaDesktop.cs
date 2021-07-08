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
    public partial class PersonaDesktop : ApplicationForm
    {
       //siempre entra por modo alta
        public PersonaDesktop(string nombre, string apellido, string mail)
        {
            InitializeComponent();
            
        }

        public void Listar()
        {
            PlanesLogic p1 = new PlanesLogic();
            this.cbPlanes.DataSource = p1.GetAll();
            //tipo person logic
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
            Listar();
            

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
