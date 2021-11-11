using Business.Entities;
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
    public partial class AlumnoInscripcionDesktop : ApplicationForm
    {
        private Business.Entities.AlumnoInscripcion _AlumnoActual;

        public AlumnoInscripcionDesktop()
        {
            InitializeComponent();
        }
        public Business.Entities.AlumnoInscripcion AlumnoActual
        {
            set { _AlumnoActual = value; }
            get { return this._AlumnoActual; }
        }

        public override void MapearDeDatos ()
        {            
            this.txtIDalumno.Text = AlumnoActual.IDAlumno.ToString();
            this.txtIDcurso.Text = AlumnoActual.IDCurso.ToString();
            this.txtNota.Text = AlumnoActual.Nota.ToString();
            this.cbCondicion.Items.Add("Regular") ;
            this.cbCondicion.Items.Add("Aprobado");
            this.cbCondicion.Items.Add("Inscripto");
            this.cbCondicion.SelectedItem = AlumnoActual.Condicion;
            this.txtIDalumno.Enabled = false;
            this.txtIDcurso.Enabled = false;
        }

        public override void MapearADatos()
        {
            AlumnoInscripcionLogic ul = new AlumnoInscripcionLogic();
            AlumnoActual.Condicion = (string)this.cbCondicion.SelectedItem;
            AlumnoActual.Nota = Convert.ToInt32(this.txtNota.Text);

            ul.Save(this.AlumnoActual);
        }
        //constructor para modificaciones
        public AlumnoInscripcionDesktop(int ID) : this()
        {            
            Business.Logic.AlumnoInscripcionLogic al = new Business.Logic.AlumnoInscripcionLogic();
            AlumnoActual = al.getOne(ID);
            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MapearADatos();
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
