using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.Win32;

namespace UI.Desktop
{
    public partial class ApplicationForm : Form
    {        
        public enum ModoForm { Alta, Baja, Modificacion, Consulta }
        public Hashtable nomBtn = new Hashtable()
        {
            { 0 ,"Guardar"},
            { 1 ,"Eliminar"},
            { 2 ,"Guardar"},
            { 3 ,"Aceptar"}
        };
        private ModoForm _modo;
        public ModoForm Modo { get {return _modo;} set {_modo = value;} }        
        public virtual void MapearDeDatos() { }       
        public virtual void MapearADatos() { }        
        public virtual void GuardarCambios() { }        
        public virtual bool Validar() { return false; }        
        public void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }        
        public void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
        public ApplicationForm()
        {
            InitializeComponent();            
        }
        
        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
