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
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();
        }

        private Materia _materiaActual;
        private MateriasLogic Logic;

        public Materia MateriaActual
        {
            get => this._materiaActual;
            set => this._materiaActual = value;
        }

        //contructor altas
        public MateriaDesktop(ModoForm modo): this()
        {
            Modo = modo;
            Logic = new MateriasLogic();
            MateriaActual = new Materia(0, "", 0, 0, 0);
            this.MapearDeDatos();
        }

        //constructor modificaciones/ consulta/ baja
        public MateriaDesktop(int id, ModoForm modo): this()
        {
            Modo = modo;
            Logic = new MateriasLogic();
            MateriaActual = Logic.GetOne(id);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.comboBoxPlan.DataSource = new PlanesLogic().GetAll();
            switch(Modo)
            {
                case ModoForm.Alta: 
                    {
                        this.btnAceptar.Text = "Registrar";
                        break;
                    }
                case ModoForm.Modificacion: 
                    {
                        this.comboBoxPlan.SelectedItem = this.MateriaActual.IDPlan;
                        this.btnAceptar.Text = "Guardar";
                        break; 
                    }
                case ModoForm.Baja: 
                    {
                        this.txtDescripcion.ReadOnly = true;
                        this.txtHorasSem.ReadOnly = true;
                        this.txtHorasTot.ReadOnly = true;
                        this.comboBoxPlan.Enabled = false;
                        this.btnAceptar.Text = "Eliminar";
                        break; 
                    }
                case ModoForm.Consulta:
                    {
                        this.txtDescripcion.ReadOnly = true;
                        this.txtHorasSem.ReadOnly = true;
                        this.txtHorasTot.ReadOnly = true;
                        this.comboBoxPlan.Enabled = false;
                        this.comboBoxPlan.SelectedItem = this.MateriaActual.IDPlan;
                        this.btnAceptar.Text = "Aceptar";
                        break;
                    }
            }
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.txtHorasSem.Text = this.MateriaActual.HsSemanales.ToString();
            this.txtHorasTot.Text = this.MateriaActual.HsTotales.ToString();
        }

        public override void MapearADatos()
        {
            this.MateriaActual.Descripcion = this.txtDescripcion.Text;
            this.MateriaActual.HsSemanales = Convert.ToInt32(this.txtHorasSem.Text);
            this.MateriaActual.HsTotales = Convert.ToInt32(this.txtHorasTot.Text);
            var item = this.comboBoxPlan.SelectedItem;// prueba
            this.MateriaActual.IDPlan = ((Plan)item).ID;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        this.MapearADatos();
                        try
                        {
                            Logic.AddNew(this.MateriaActual);
                        }
                        catch (Exception ex)
                        {
                            Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.MapearADatos();
                        try
                        {
                            Logic.Save(this.MateriaActual);
                        }
                        catch (Exception ex)
                        {
                            Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.MapearADatos();
                        try
                        {
                            Logic.Delete(this.MateriaActual.ID);
                        }
                        catch (Exception ex)
                        {
                            Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
            }
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
