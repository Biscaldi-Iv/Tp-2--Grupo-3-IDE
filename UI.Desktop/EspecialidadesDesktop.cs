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
using Business.Entities;

namespace UI.Desktop
{
    public partial class EspecialidadesDesktop : ApplicationForm
    {
        public EspecialidadesDesktop()
        {
            InitializeComponent();
        }

        private Especialidad _especialidadActual;

        public Especialidad EspecialidadActual
        {
            get => this._especialidadActual;
            set { this._especialidadActual = value; }
        }

        //constructor para altas
        public EspecialidadesDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            //falta ver el modo en que entra y setear el texto del boton aceptar/guardar/baja segun sea necesario
            Especialidad esp = new Especialidad(0, "");
            EspecialidadActual = esp;
            MapearDeDatos();
        }

        //constructor de modificaciones
        public EspecialidadesDesktop(int Id, ModoForm modo) : this()
        {
            Modo = modo;
            EspecialidadLogic espL = new EspecialidadLogic();
            this.EspecialidadActual= espL.GetOne(Id);
            MapearDeDatos();
        }

        public override void MapearDeDatos() 
        {
            this.tboxId.Text = this.EspecialidadActual.ID.ToString();
            this.tboxEspecialidad.Text = this.EspecialidadActual.Descripcion;
        }
        public override void MapearADatos() { }
        public override void GuardarCambios() { }
        public override bool Validar() { return false; }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
