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
        private DataTable dt;
        private DataView dv;
        

        public DocentesCursos()
        {
            InitializeComponent();
            
            CursosL = new CursosLogic();
            PlanesL = new PlanesLogic();
            PersonasL = new PersonaLogic();
            DCL = new DocentesCursosLogic();
            MapearDataTable();
            Listar();
        }

        public CursosLogic CursosL { get; set; }
        public PlanesLogic PlanesL { get; set; }
        public DocentesCursosLogic DCL { get; set; }
        public List<DocenteCurso> docenteCursos { set; get; }
        public PersonaLogic PersonasL { get; set; }
        public List<docurs> docu;

        public void Listar()
        {            
            this.cBoxPlanFiltro.DataSource = PlanesL.GetAll();
            List<Persona> docentes = PersonasL.GetDocentes();
            docenteCursos = DCL.GetDocentesCursos();
            var docur = (from dc in docenteCursos
                         join per in PersonasL.GetAll() on dc.IDDocente equals per.ID
                         join cur in CursosL.getAll() on dc.IDCurso equals cur.ID into docurso
                         from dcc in docurso.DefaultIfEmpty()
                         select new docurs()
                         {
                             IDcurso = dcc == null ? 0 : dcc.ID,
                             DescCurso = dcc.Descripcion,
                             IDdocente = dc.IDDocente,
                             Nomdocente = per.Nombre,
                             Apdocente = per.Apellido,
                             Cargodc = dc.Cargo,
                             IDdc = dc.ID,
                             IDPlan = per.IDPlan,
                            }).ToList();
            MapearADataTable(docur);
            dgvDocentesCursos.DataSource = dt;
        }

        private void MapearADataTable(List<docurs> docur)
        {
            foreach (var dc in docur)
            {                
                dt.Rows.Add(dc.IDcurso, dc.DescCurso,dc.IDdocente,dc.Nomdocente,dc.Apdocente,dc.Cargodc,dc.IDdc, dc.IDPlan);
            }
        }
        private DataTable MapearDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("IDcurso");
            dt.Columns.Add("DescCurso");
            dt.Columns.Add("IDdocente");
            dt.Columns.Add("Nomdocente");
            dt.Columns.Add("Apdocente");
            dt.Columns.Add("Cargodc");
            dt.Columns.Add("IDDictado");
            dt.Columns.Add("IDPlan");
            return dt;

        }

               
        private void cBoxPlanFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            int val;
            dv = dt.DefaultView;
            Int32.TryParse(cBoxPlanFiltro.SelectedValue.ToString(), out val);
            dv.RowFilter = string.Format("IDPlan LIKE '%{0}%'",val);


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

    public class docurs
    {
        public docurs()
        {
        }

        public docurs(int iDdc, int iDcurso, string descCurso, int iDdocente, string nomdocente, string apdocente, TiposCargo cargodc, int iddc, int idplan)
        {
            this.IDdc = iDdc;
            this.IDcurso = iDcurso;
            this.DescCurso = descCurso;
            this.IDdocente = iDdocente;
            this.Nomdocente = nomdocente;
            this.Apdocente = apdocente;
            this.Cargodc = cargodc;
            this.IDdc = iddc;
            this.IDPlan = idplan;
            
        }
        public int IDPlan { get; set; }
        public int IDdc { get; set; }
        public int IDcurso { get; set; }       
        public string DescCurso { get; set; }
        public int IDdocente { get; set; }
        public string Nomdocente { get; set; }
        public string Apdocente { get; set; }
        public TiposCargo Cargodc { get; set; }
                
    }
}
