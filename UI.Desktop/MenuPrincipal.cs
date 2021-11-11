using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UI.Desktop
{
    public partial class MenuPrincipal : ApplicationForm
    {
       

        public MenuPrincipal()
        {
            InitializeComponent();
            LoadTheme();
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed); 
        }
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if(e.Category==UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            }
        }

        private void LoadTheme()
        {
            var themeColor = WinTema.GetAccentColor();

            menuStrip1.BackColor = themeColor;                       

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
                            aBMCToolStripMenuItem.Visible = true;
                            docentesToolStripMenuItem.Enabled = true;
                            docentesToolStripMenuItem.Visible = true;
                            inscripcionACursoDocenteToolStripMenuItem.Visible = true;
                            alumnosToolStripMenuItem.Enabled = false;
                            alumnosToolStripMenuItem.Visible = false;
                            break;
                        }
                    case "Docente":
                        {
                            docentesToolStripMenuItem.Enabled = true;
                            docentesToolStripMenuItem.Visible = true;
                            notasToolStripMenuItem.Visible = true;
                            aBMCToolStripMenuItem.Enabled = false;
                            aBMCToolStripMenuItem.Visible = false;                     
                            inscripcionACursoDocenteToolStripMenuItem.Visible = false;
                            alumnosToolStripMenuItem.Enabled = false;
                            alumnosToolStripMenuItem.Visible = false;
                            break;
                        }
                    case "Alumno":
                        {                            
                            alumnosToolStripMenuItem.Enabled = true;
                            alumnosToolStripMenuItem.Visible = true;
                            docentesToolStripMenuItem.Enabled = false;
                            docentesToolStripMenuItem.Visible = false;
                            notasToolStripMenuItem.Visible = false;
                            aBMCToolStripMenuItem.Enabled = false;
                            aBMCToolStripMenuItem.Visible = false;
                            inscripcionACursoDocenteToolStripMenuItem.Visible = false;
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
            alumnosToolStripMenuItem.Enabled = false;
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
            Cursos frminscripcion = new Cursos();
            frminscripcion.ShowDialog();
            Program.menu.Show();
        }

        private void misCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.menu.Hide();           
            AlumnoInscripciones frminscripcion = new AlumnoInscripciones();
            frminscripcion.ShowDialog();
            Program.menu.Show();
        }

        private void inscripcionACursoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.menu.Hide();
            DocentesCursos docentescursos = new DocentesCursos();
            docentescursos.ShowDialog();
            Program.menu.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.menu.Hide();
            AlumnoInscripciones frminscripcion = new AlumnoInscripciones();
            frminscripcion.ShowDialog();
            Program.menu.Show();
        }
    }
}
