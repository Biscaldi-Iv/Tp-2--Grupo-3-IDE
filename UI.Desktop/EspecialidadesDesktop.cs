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
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        this.btnGuardar.Text = "Registrar";
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.btnGuardar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.tboxEspecialidad.ReadOnly = true;
                        this.btnGuardar.Text = "Eliminar";
                        break;
                    }
            }
            this.tboxId.Text = this.EspecialidadActual.ID.ToString();
            this.tboxEspecialidad.Text = this.EspecialidadActual.Descripcion;
        }

        public override void MapearPersona() 
        {
            this.EspecialidadActual.ID = Convert.ToInt32(this.tboxId.Text);
            this.EspecialidadActual.Descripcion = this.tboxEspecialidad.Text;
        }

        //public override void GuardarCambios() { } ###no es necesario porque add y savechanges de logic guardan directamente
        public override bool Validar() { return false; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EspecialidadLogic espL = new EspecialidadLogic();
            MapearPersona();
            switch (Modo)
            {
                case ModoForm.Alta: 
                    {
                        espL.AddNew(EspecialidadActual);
                        break;
                    }
                case ModoForm.Modificacion: 
                    {
                        espL.SaveChanges(EspecialidadActual);
                        break; 
                    }
                case ModoForm.Baja:
                    {
                        espL.Delete(Convert.ToInt32(this.tboxId.Text));
                        break;
                    }
            }
            this.Close();
        }
    }
}
