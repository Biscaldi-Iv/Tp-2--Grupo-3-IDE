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
    public partial class CursosDesktop : ApplicationForm
    {
        private Curso _cursoActual;
        public Curso CursoActual
        {
            get => this._cursoActual;
            set => this._cursoActual = value;
        }
        private CursosLogic cursosLogic=new CursosLogic();
        
        public CursosDesktop()
        {
            InitializeComponent();
        }

        public CursosDesktop(ModoForm modo) : base()
        {
            Modo = modo;
            this.CursoActual = new Curso(0, 0, 0, 2021, 0, "");
            MapearDeDatos();
        }

        public CursosDesktop(int id, ModoForm modo): base()
        {
            Modo = modo;
            this.CursoActual = cursosLogic.getOne(id);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            //this.comboBoxMateria.DataSource = new MateriasLogic().GetAll();//error
            this.comboBoxMateria.DataSource = new MateriasLogic().GetAll();
            this.comboBoxComision.DataSource = new ComisionLogic().GetAll();
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        this.btnAceptar.Text = "Registrar";
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.Text = this.CursoActual.Descripcion;
                        this.comboBoxMateria.SelectedItem = this.CursoActual.IDMateria;
                        this.comboBoxComision.SelectedItem = this.CursoActual.IDComision;
                        this.comboBoxAnio.SelectedItem = this.CursoActual.AnioCalendario;
                        this.textCupo.Text = this.CursoActual.Cupo.ToString();
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.Text = this.CursoActual.Descripcion;
                        this.comboBoxMateria.SelectedItem = this.CursoActual.IDMateria;
                        this.comboBoxComision.SelectedItem = this.CursoActual.IDComision;
                        this.comboBoxAnio.SelectedItem = this.CursoActual.AnioCalendario;
                        this.textCupo.Text = this.CursoActual.Cupo.ToString();
                        this.comboBoxAnio.Enabled = false;
                        this.comboBoxComision.Enabled = false;
                        this.comboBoxMateria.Enabled = false;
                        this.textCupo.ReadOnly = true;
                        this.btnAceptar.Text = "Eliminar";
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.Text = this.CursoActual.Descripcion;
                        this.comboBoxMateria.SelectedItem = this.CursoActual.IDMateria;
                        this.comboBoxComision.SelectedItem = this.CursoActual.IDComision;
                        this.comboBoxAnio.SelectedItem = this.CursoActual.AnioCalendario;
                        this.textCupo.Text = this.CursoActual.Cupo.ToString();
                        this.comboBoxAnio.Enabled = false;
                        this.comboBoxComision.Enabled = false;
                        this.comboBoxMateria.Enabled = false;
                        this.textCupo.ReadOnly = true;
                        break;
                    }
            }
        }

        public override void MapearADatos()
        {
            this.CursoActual.IDMateria = (int)this.comboBoxMateria.SelectedValue;
            this.CursoActual.IDComision = (int)this.comboBoxComision.SelectedValue;
            this.CursoActual.AnioCalendario = Convert.ToInt32(this.comboBoxAnio.Text);
            this.CursoActual.Cupo = Convert.ToInt32(this.textCupo.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool puedeCerrar = false;
            switch(Modo)
            {
                case ModoForm.Alta: 
                    {
                        MapearADatos();
                        puedeCerrar = Validaciones.ValidaCurso(this.CursoActual);
                        if (puedeCerrar)
                        {
                            try
                            {
                                cursosLogic.AddNew(this.CursoActual);

                            }
                            catch (Exception ex)
                            {
                                puedeCerrar = false;
                                this.Notificar("Error", "No ha sido posible agregar el curso: " + ex.Message, 
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else 
                        {
                            this.Notificar("Advertencia", "No se puede agregar el curso porque ya existe uno similar",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        MapearADatos();
                        puedeCerrar = Validaciones.ValidaCurso(this.CursoActual);
                        if (puedeCerrar)
                        {
                            try
                            {
                                cursosLogic.AddNew(this.CursoActual);

                            }
                            catch (Exception ex)
                            {
                                puedeCerrar = false;
                                this.Notificar("Error", "No ha sido posible modificar el curso: " + ex.Message,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            this.Notificar("Advertencia", "No se guardaron los cambios del curso porque existe uno similar",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    }
                case ModoForm.Baja:
                    {
                        //validar si hay que eliminar inscripciones-alum/docentes
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        puedeCerrar = true;
                        break;
                    }
            }
            if(puedeCerrar)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
