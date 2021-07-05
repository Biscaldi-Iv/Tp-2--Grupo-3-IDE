using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class PlanesDesktop : Form
    {
        public PlanesDesktop()
        {
            InitializeComponent();
        }

        public partial class UsuarioDesktop : ApplicationForm
        {
            private Planes _PlanActual;
            public Planes PlanActual
            {
                get =>  this._PlanActual;
                set => _PlanActual = value;
            }

            public override void MapearDeDatos()
            {

            }

            public override void MapearADatos()
            {

            }

            private void GuardarMapeoADatos()
            {

            }

            public override void GuardarCambios()
            {

            }

            public override bool Validar()
            {
                return false;
            }


        }

    }
}
