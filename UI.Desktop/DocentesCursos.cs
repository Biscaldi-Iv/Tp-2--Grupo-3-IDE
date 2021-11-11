using Microsoft.Win32;
using Business.Logic;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class DocentesCursos : Form
    {
        public DocentesCursos()
        {
            InitializeComponent();

            CursosL = new CursosLogic();
            PlanesL = new PlanesLogic();
            PersonasL = new PersonaLogic();
            DCL = new DocentesCursosLogic();
            Listar();
        }

        public CursosLogic CursosL { get; set; }
        public PlanesLogic PlanesL { get; set; }
        public DocentesCursosLogic DCL { get; set; }
        public PersonaLogic PersonasL { get; set; }

        public void Listar()
        {
            var cur_doc = (List<ValueTuple<DocenteCurso, Curso, Persona>>)DCL.cursos_asignados();
            //en el dgv solo se muestran los cursos con docentes asignados
            DataTable dataTable1 = new DataTable();
            dataTable1.TableName = "Docente_Curso";
            dataTable1.Columns.Add("ID Curso");
            dataTable1.Columns.Add("Curso");
            dataTable1.Columns.Add("ID Docente");
            dataTable1.Columns.Add("Nombre Docente");
            dataTable1.Columns.Add("Apellido del Docente");
            dataTable1.Columns.Add("Cargo");
            dataTable1.Columns.Add("Dictado");
            foreach (var dc in cur_doc)
            {
                dataTable1.Rows.Add(dc.Item2.ID, dc.Item2.Descripcion, dc.Item3.ID,
                    dc.Item3.Nombre, dc.Item3.Apellido, dc.Item1.Cargo.TipoCargo, dc.Item1.ID);
            }

            this.dgvDocentesCursos.DataSource = dataTable1;
            //this.dgvDocentesCursos.Selec

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DocentesCursosForm agregar = new DocentesCursosForm();
            agregar.ShowDialog();
        }

        /*
            id de dictado debe pasarse al form pero solo como variable para guardar cambios,
            NO MOSTRAR

            el dgv solo debe mostrar en todo momento los cursos de un plan
            -ver como hacer join en linq de forma que no desaparezcan los registros que no tienen docente

            -posiblemente agregar boton para mostrar solo los cursos que no tiene docente para el plan elegido

            el combo box debe por defecto tener un plan elegido y esto debe hacerse al comienzo para poder filtrar al mostrar dgv

            debe haber una variable de <<var de LINQ>> del join docente con docente curso, esta debe tener todos los crusos con o sin
            docente asignado y el filtro de lo que se muestra es sobre esta var

            actualizar refreza los datos desde bd asi como lo hacen agregar/modificar registros
            cambiar de plan en combo box no busca en bd

        */
    }
}