using Business.Logic;
using Microsoft.Win32;
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
    public partial class AlumnoInscripciones : ApplicationForm
    {
        public AlumnoInscripciones()
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
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            }
        }

        private void LoadTheme()
        {
            var themeColor = WinTema.GetAccentColor();
            tsAlumnosIncripciones.BackColor = themeColor;
            tcAlumnosInscripciones.TopToolStripPanel.BackColor = themeColor;
        }

        public void Listar()
        {
            switch (Program.tipo.Descripcion)
            {
                case "Administrador":
                    {
                        AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
                        UsuarioLogic usu = new UsuarioLogic();
                        var usuarios = usu.GetAll();
                        var alumnos = ail.getAll();
                        var usu_alu = (from u in usuarios
                                       join usual in alumnos on u.ID equals usual.IDAlumno
                                       select (usual, u.Nombre, u.Apellido)).ToList();

                        DataTable dataTable1 = new DataTable();
                        dataTable1.TableName = "Alumno_Inscripcion";
                        dataTable1.Columns.Add("ID inscripcion");
                        dataTable1.Columns.Add("ID Curso");
                        dataTable1.Columns.Add("ID Alumno");
                        dataTable1.Columns.Add("Nombre Alumno");
                        dataTable1.Columns.Add("Apellido Alumno");
                        dataTable1.Columns.Add("Condicion");
                        dataTable1.Columns.Add("Nota");
                        foreach (var ua in usu_alu)
                        {
                            dataTable1.Rows.Add(ua.usual.ID, ua.usual.IDCurso, ua.usual.IDAlumno, ua.Nombre, ua.Apellido, ua.usual.Condicion, ua.usual.Nota);
                        }

                        this.dgvAlumnoIncripciones.DataSource = dataTable1;
                        break;
                    }
                case "Docente":
                    {
                        AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
                        UsuarioLogic usu = new UsuarioLogic();
                        var usuarios = usu.GetAll();
                        var alumnos = ail.getAll();
                        var usu_alu = (from u in usuarios
                                       join usual in alumnos on u.ID equals usual.IDAlumno
                                       select (usual, u.Nombre, u.Apellido)).ToList();

                        DataTable dataTable1 = new DataTable();
                        dataTable1.TableName = "Alumno_Inscripcion";
                        dataTable1.Columns.Add("ID inscripcion");
                        dataTable1.Columns.Add("ID Curso");
                        dataTable1.Columns.Add("ID Alumno");
                        dataTable1.Columns.Add("Nombre Alumno");
                        dataTable1.Columns.Add("Apellido Alumno");
                        dataTable1.Columns.Add("Condicion");
                        dataTable1.Columns.Add("Nota");
                        foreach (var ua in usu_alu)
                        {
                            dataTable1.Rows.Add(ua.usual.ID, ua.usual.IDCurso, ua.usual.IDAlumno, ua.Nombre, ua.Apellido, ua.usual.Condicion, ua.usual.Nota);
                        }

                        this.dgvAlumnoIncripciones.DataSource = dataTable1;
                        break;
                    }
                case "Alumno":
                    {
                        AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
                        this.dgvAlumnoIncripciones.DataSource = ail.getCursosInscripto(Program.usuarioLog.ID);
                        break;
                    }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlumnoInscripciones_Load(object sender, EventArgs e)
        {
            Listar();
            switch (Program.tipo.Descripcion)
            {
                case "Administrador":
                    {
                        this.tsAlumnosIncripciones.Visible = true;
                        break;
                    }
                case "Docente":
                    {
                        this.tsAlumnosIncripciones.Visible = true;
                        break;
                    }
                case "Alumno":
                    {

                        break;
                    }
                default: break;

            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ind = dgvAlumnoIncripciones.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dgvAlumnoIncripciones.Rows[ind];
            int ID = Convert.ToInt32(dataGridViewRow.Cells["ID inscripcion"].Value);
            AlumnoInscripcionDesktop editar = new AlumnoInscripcionDesktop(ID);           
            editar.ShowDialog();
            this.Listar();
        }
    }
}
