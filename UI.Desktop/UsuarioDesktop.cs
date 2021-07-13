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


//falta revisar manejo respecto a la existencia de persona
namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        private Usuario _UsuarioActual;
        
        //mapea lo que recibe y lo manda al form
        public override void MapearDeDatos() 
        {
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            //revisar si esto no se repite con de Load
            switch(Modo)
            {
                case ModoForm.Modificacion: 
                    {
                        this.txtEmail.ReadOnly = true;//no se puede modificar el mail
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Baja:
                    {
                        //no se podran modificar los valores de los campos

                        this.txtApellido.Enabled = false;
                        this.txtNombre.Enabled = false;
                        this.txtEmail.Enabled = false;
                        this.txtUsuario.Enabled = false;
                        this.chkHabilitado.Enabled = false;
                        this.txtClave.Enabled = false;
                        this.txtConfirmarClave.Hide();
                        this.txtID.Enabled = false;
                        this.btnAceptar.Text = "Eliminar";
                        break;
                    }
                case ModoForm.Alta:
                    {
                        this.btnAceptar.Text = "Registrar";
                        break;
                    }
            }
        }

        //deberia revisar dependiendo el modo si ha que ver la persona
        public override void MapearADatos() 
        {
            UsuarioLogic ul = new UsuarioLogic();
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        this.UsuarioActual.State = BusinessEntity.States.New;
                        this.MapeoADatos();
                        PersonaLogic pl = new PersonaLogic();
                        if (!pl.VerificarExistencia(this.UsuarioActual.Email))//si no hay persona registrada con el mail de usuario actual
                        {
                            PersonaDesktop persona = new PersonaDesktop(this.UsuarioActual.Nombre, this.UsuarioActual.Apellido, this.UsuarioActual.Email, ModoForm.Alta);
                            persona.ShowDialog();
                        }
                        this.MapeoADatos();
                        this.UsuarioActual.IdPersona = pl.GetIDByMail(this.UsuarioActual.Email);
                        ul.AddNew(this.UsuarioActual);
                        break;
                    }
                case ModoForm.Baja:
                    {
                        //baja fisica
                        ul.Delete(this.UsuarioActual.ID);
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.UsuarioActual.State = BusinessEntity.States.Modified;
                        MapeoADatos();
                        ul.Save(this.UsuarioActual);
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        break;
                    }
            }
        }


        //del form a usuario actual
        private void MapeoADatos() 
        {
            this.UsuarioActual.Apellido = this.txtApellido.Text;
            this.UsuarioActual.Nombre = this.txtNombre.Text;
            this.UsuarioActual.Email = this.txtEmail.Text;
            this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
            this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
            this.UsuarioActual.Clave = this.txtClave.Text;
            this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
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
        public Usuario UsuarioActual 
        { 
            set {_UsuarioActual = value;} 
            get{ return this._UsuarioActual; }  
        }
        
        public UsuarioDesktop()
        {           
            InitializeComponent();           
        }

        //constructor para altas
        public UsuarioDesktop(ModoForm modo) : this() 
        { 
            Modo = modo;
            Usuario usr = new Usuario(0,"","","","","",false,0,true);
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
            switch(Modo)
            {
                case ModoForm.Baja:
                    {
                        this.txtNombre.ReadOnly = true;
                        this.txtApellido.ReadOnly = true;
                        this.txtEmail.ReadOnly = true;
                        this.txtUsuario.ReadOnly = true;
                        this.chkHabilitado.Enabled = false;
                        this.btnAceptar.Text = "Eliminar";
                        break;
                    }
                case ModoForm.Alta:
                    {
                        this.btnAceptar.Text = "Registar";
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.btnAceptar.Text = "Aceptar";
                        break;
                    }
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e) 
        {
            this.MapeoADatos();
            switch (Modo) 
            {
                case ModoForm.Baja:
                    {
                        if (MessageBox.Show("Esta seguro que desea borrar este Usuario?", "Ciudado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                             new UsuarioLogic().Delete(this.UsuarioActual.ID);
                             this.Close();
                        }
                        else 
                        {
                            this.Close();
                        }
                        break;
                    }
                case ModoForm.Alta:
                    {
                        PersonaLogic pl = new PersonaLogic();
                        if (pl.VerificarExistencia(this.UsuarioActual.Email))
                        {
                            //persona existe
                            //revisar si es necesario actualizar datos de persona
                            this.UsuarioActual.IdPersona = pl.GetIDByMail(this.UsuarioActual.Email);
                        }
                        else
                        {
                            PersonaDesktop pd = new PersonaDesktop(this.UsuarioActual.Nombre, this.UsuarioActual.Apellido,
                                this.UsuarioActual.Email, ModoForm.Alta);
                            pd.ShowDialog();
                            this.UsuarioActual.IdPersona = pl.GetIDByMail(this.UsuarioActual.Email);
                        }
                        new UsuarioLogic().AddNew(this.UsuarioActual);
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        new UsuarioLogic().Save(this.UsuarioActual);
                        break;
                    }
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
