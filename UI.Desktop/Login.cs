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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            //InitializeComponent();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogic ul = new UsuarioLogic();
            PersonaLogic pl = new PersonaLogic();
            PlanesLogic planl = new PlanesLogic();
            TipoPersonaLogic tpl = new TipoPersonaLogic();
            if (ul.VerificarUsuario(this.txtUsuario.Text, this.txtPass.Text))
            {
                Program.usuarioLog = new UsuarioLogic().RecuperarUsuario(this.txtUsuario.Text, this.txtPass.Text);
                Program.tipo = tpl.GetOne(pl.GetOne(Program.usuarioLog.IdPersona).TipoPersona);
                Program.plan = planl.GetOne(pl.GetOne(Program.usuarioLog.IdPersona).IDPlan);
                this.DialogResult = DialogResult.OK; 
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkOlvidaPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvide mi contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
