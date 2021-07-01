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
        
        public override void MapearDeDatos() 
        {
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.btnAceptar.Text = nomBtn[(int)Modo].ToString();
        }
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
            UsuarioLogic ul = new UsuarioLogic(new Data.Database.UsuarioAdapter());          
            this.UsuarioActual = ul.GetOne(ID);
            MapearDeDatos();         
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }
    }
}
