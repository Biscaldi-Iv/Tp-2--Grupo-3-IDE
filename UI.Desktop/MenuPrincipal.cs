using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnABMC_Click(object sender, EventArgs e)
        {
            Program.menu.Hide();
            SubMenuABMC abmc = new SubMenuABMC();
            abmc.ShowDialog();
            Program.menu.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpcionLogin();
        }

        private void OpcionLogin()
        {
            formLogin frm = new formLogin();
            frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.menu.Hide();
            Comisiones frmComisiones = new Comisiones();
            frmComisiones.ShowDialog();
            Program.menu.Show();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.menu.Hide();
            FormListaEspecialidades frmEspecialidades = new FormListaEspecialidades();
            frmEspecialidades.ShowDialog();
            Program.menu.Show();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.menu.Hide();
            Planes frmPlanes = new Planes();
            frmPlanes.ShowDialog();
            Program.menu.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.menu.Hide();
            Usuarios frmUsuaios = new Usuarios();
            frmUsuaios.ShowDialog();
            Program.menu.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
