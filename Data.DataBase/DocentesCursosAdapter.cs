using Business.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class DocentesCursosAdapter: Adapter
    {
        public DocentesCursosAdapter() : base() { }

        public List<DocenteCurso> GetDocentesCursos()
        {
            List<DocenteCurso> dc = new List<DocenteCurso>();
            this.OpenConnection();
            try
            {
                SqlDataReader rdr = this.ExecuteReader("SELECT id_dictado, id_curso, id_docente, cargo " +
                    "FROM [Academia].[dbo].[docentes_cursos]");
                while (rdr.Read())
                {
                    DocenteCurso dcur = new DocenteCurso(rdr.GetInt32(0),rdr.Get(3) ,rdr.GetInt32(1), rdr.GetInt32(2) );
                    dc.Add(dcur);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("BD>> No fue posible recuperar los cursos de docentes:" + ex.Message + "||");
            }
            finally
            {
                this.CloseConnection();
            }

            return dc;
        }

        public void AddNew(DocenteCurso dc)
        {
            //hacer
        }
    }
}
