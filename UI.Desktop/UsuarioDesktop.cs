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
    public partial class UsuarioDesktop : ApplicationForm
    {
        private Usuario _UsuarioActual;

        public override void MapearDeDatos() { }
        public override void MapearADatos() { }
        public override void GuardarCambios() { }
        public override bool Validar() { return false; }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        public Usuario UsuarioActual { set {_UsuarioActual = value;} get{ return this._UsuarioActual; }  }
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        public UsuarioDesktop(ModoForm modo) : this() { Modo = modo; }
        public UsuarioDesktop(int ID, ModoForm modo) : this() 
        { 
            Modo = modo;
            this.UsuarioNegocio = new UsuarioLogic(new Data.Database.UsuarioAdapter());
            Usuario usr = new();
            usr = UsuarioNegocio.GetOne(ID);
            
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }
    }
}
