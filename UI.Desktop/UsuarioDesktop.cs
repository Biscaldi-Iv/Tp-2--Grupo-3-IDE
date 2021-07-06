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
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.btnAceptar.Text = nomBtn[(int)Modo].ToString();
        }
        public override void MapearADatos() 
        {
            if (Modo == ModoForm.Alta)
            {
                UsuarioActual = new Usuario(0,"","","","","",false);
                this.UsuarioActual.State = BusinessEntity.States.New;
                GuardarMapeoADatos();
            } 
            if (Modo == ModoForm.Modificacion)
            {                  
                this.UsuarioActual.State = BusinessEntity.States.Modified;
                GuardarMapeoADatos();
            }
            if (Modo == ModoForm.Baja)
            {
                if (ValidarClave(txtClave.Text)) { this.UsuarioActual.State = BusinessEntity.States.Deleted; }
                else { Notificar("Clave incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
        }
        private void GuardarMapeoADatos() //Temporal hasta implementar mejor modificacion-chekeo de clave-modificar clave
        {
            this.UsuarioActual.Apellido = this.txtApellido.Text;
            this.UsuarioActual.Nombre = this.txtNombre.Text;
            this.UsuarioActual.Email = this.txtEmail.Text;
            this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
            this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
            this.UsuarioActual.Clave = this.txtClave.Text;
            this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
        }
        public override void GuardarCambios() 
        {            
            MapearADatos();
            UsuarioLogic ul = new UsuarioLogic();
            ul.Save(_UsuarioActual);
        }
        public bool ValidarClave(string c)  //Falta implementar
        {
            if (c == this.UsuarioActual.Clave)
            {
                return true;
            }
            return false;
        }
        public override bool Validar() 
        { 
            if (this.txtApellido.Text.Length == 0 || this.txtNombre.Text.Length == 0 || this.txtUsuario.Text.Length == 0 || !(this.txtEmail.Text.Contains("@gmail.com")) 
                || this.txtClave.Text != this.txtConfirmarClave.Text)
            {
                Notificar("Error","Faltan completar campos o contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else { return true; }
        }
        public Usuario UsuarioActual { set {_UsuarioActual = value;} get{ return this._UsuarioActual; }  }
        public UsuarioDesktop()
        {           
            InitializeComponent();           
        }

        //constructor para altas
        public UsuarioDesktop(ModoForm modo) : this() 
        { 
            Modo = modo;
            Usuario usr = new Usuario(0,"","","","","",false);
            UsuarioActual = usr; 
            MapearDeDatos(); 
        }

        //constructor para modificaciones
        public UsuarioDesktop(int ID, ModoForm modo) : this() 
        { 
            Modo = modo;
            //falta ver el modo en que entra y setear el texto del boton aceptar/guardar/baja segun sea necesario
            UsuarioLogic ul = new UsuarioLogic();          
            this.UsuarioActual = ul.GetOne(ID);
            MapearDeDatos();         
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {
            if (Modo == ModoForm.Baja)
            {
                this.txtNombre.ReadOnly = true;
                this.txtApellido.ReadOnly = true;
                this.txtEmail.ReadOnly = true;
                this.txtUsuario.ReadOnly = true;              
                this.chkHabilitado.Enabled = false;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e) //Optimizar
        {
            if (Modo == ApplicationForm.ModoForm.Baja)
            {
                if (ValidarClave(txtConfirmarClave.Text))
                {
                    if (MessageBox.Show("Esta seguro que desea borrar este Usuario?", "Ciudado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        GuardarCambios();
                        this.Close();
                    }
                    else { this.Close(); }
                } else { Notificar("Atencion", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }         
            }                       
            else
            {
                if (Validar())
                {
                    GuardarCambios();
                    this.Close();
                }
            }
        }        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
