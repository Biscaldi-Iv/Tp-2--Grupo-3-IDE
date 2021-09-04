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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //formLogin appLogin = new formLogin();
            //if (appLogin.ShowDialog() != DialogResult.OK)
            //{
                //this.Dispose();
            //}
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpcionLogin();
            if(Program.usuarioLog!=null)
            {
                cerrarSesionToolStripMenuItem.Enabled = true;
                loginToolStripMenuItem.Enabled = false;
                switch (Program.tipo.Descripcion)
                {
                    case "Administrador":
                        {
                            aBMCToolStripMenuItem.Enabled = true;
                            alumnosToolStripMenuItem.Enabled = true;
                            break;
                        }
                    case "Docente":
                        {
                            aBMCToolStripMenuItem.Enabled = false;
                            alumnosToolStripMenuItem.Enabled = false;
                            break;
                        }
                    case "Alumno":
                        {
                            aBMCToolStripMenuItem.Enabled = false;
                            alumnosToolStripMenuItem.Enabled = true;
                            break;
                        }
                    default: break;
                }
            }
            //las variables de program determinan si hay que habilitar botones o no
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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarSesionToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = true;
            aBMCToolStripMenuItem.Enabled = false;
            Program.usuarioLog = null;
            Program.tipo = null;
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.menu.Hide();
            Materias frmMaterias = new Materias();
            frmMaterias.ShowDialog();
            Program.menu.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.menu.Hide();
            Cursos frmCursos = new Cursos();
            frmCursos.ShowDialog();
            Program.menu.Show();
        }

        private void inscripcionACursadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.menu.Hide();
            Inscripciones frminscripcion = new Inscripciones(ApplicationForm.ModoForm.Alta);
            frminscripcion.ShowDialog();
            Program.menu.Show();
        }
    }
}
