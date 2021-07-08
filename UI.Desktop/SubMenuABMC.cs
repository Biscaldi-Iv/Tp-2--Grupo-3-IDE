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
    public partial class SubMenuABMC : Form
    {
        public SubMenuABMC()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.menu.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {          
            this.Dispose();
            Usuarios usuario = new Usuarios();
            usuario.ShowDialog();
            
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormListaEspecialidades especialidades = new FormListaEspecialidades();
            especialidades.ShowDialog();
        }

        private void btnPlanesyMaterias_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Planes planes = new Planes();
            planes.ShowDialog();
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Comisiones comisiones = new Comisiones();
            comisiones.ShowDialog();
        }
    }
}
