using Business.Logic;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace UI.Desktop
{
    public partial class DocentesCursos : Form
    {                
        public DocentesCursos()
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
            tscDocentesCursos.TopToolStripPanel.BackColor = themeColor;
            tsDocentesCursos.BackColor = themeColor;
        }

        public void Listar()
        {
            CursosLogic curso = new CursosLogic();
            this.dgvDocentesCursos.DataSource = curso.getAll();
        }

        private void DocentesCursos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DocentesCursosForm agregar = new DocentesCursosForm();            
            agregar.ShowDialog();
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        /*
id de dictado debe pasarse al form pero solo como variable para guardar cambios,
NO MOSTRAR

el dgv solo debe mostrar en todo momento los cursos de un plan
-ver como hacer join en linq de forma que no desaparezcan los registros que no tienen docente

-posiblemente agregar boton para mostrar solo los cursos que no tiene docente para el plan elegido

el combo box debe por defecto tener un plan elegido y esto debe hacerse al comienzo para poder filtrar al mostrar dgv

debe haber una variable de <<var de LINQ>> del join docente con docente curso, esta debe tener todos los crusos con o sin
docente asignado y el filtro de lo que se muestra es sobre esta var

actualizar refreza los datos desde bd asi como lo hacen agregar/modificar registros
cambiar de plan en combo box no busca en bd

*/
    }

    
}
