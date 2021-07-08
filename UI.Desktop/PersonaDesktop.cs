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
    public partial class PersonaDesktop : ApplicationForm
    {
       //siempre entra por modo alta
        public PersonaDesktop()
        {
            InitializeComponent();
        }

        //constructor de altas
        public PersonaDesktop(string nombre, string apellido, string mail, ModoForm modo): this()
        {
            PersonaActual = new Persona(0, nombre, apellido, "", mail, "", new DateTime(2000, 1, 1), 0, 0, 0);
            Modo = modo;
        }

        private Persona _per_act;

        public Persona PersonaActual
        {
            get => this._per_act;
            set => this._per_act = value;
        }



        public override void MapearDeDatos()
        {
            PlanesLogic p1 = new PlanesLogic();
            this.cbPlanes.DataSource = p1.GetAll();
            TipoPersonaLogic tpl = new TipoPersonaLogic();
            this.comboBoxTiposPer.DataSource = tpl.GetAll();
        }

        public override void MapearADatos() 
        {
            this.PersonaActual.Direccion = this.txtDireccion.Text;
            this.PersonaActual.Telefono = this.txtTelefono.Text;
            this.PersonaActual.Legajo = Convert.ToInt32(this.txtLegajo.Text);
            this.PersonaActual.FechaNacimiento = this.dateTimePicker1.Value;
            TipoPersonaLogic tpl = new TipoPersonaLogic();
            this.PersonaActual.TipoPersona = tpl.GetByDesc(this.comboBoxTiposPer.Text).ID;
            PlanesLogic p1 = new PlanesLogic();
            this.PersonaActual.IDPlan = p1.GetByDesc(this.cbPlanes.Text).ID;
        }










        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
            MapearDeDatos();
            

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Modo) 
            {
                case ModoForm.Alta:
                    {
                        MapearADatos();
                        new PersonaLogic().AddNew(PersonaActual);
                        break;
                    }
            }
            this.Close();
        }
    }
}
