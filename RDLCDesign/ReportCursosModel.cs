using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RDLCDesign
{
    public partial class ReportCursosModel : DbContext
    {
        public ReportCursosModel()
            : base("name=ReportCursosModel")
        {
        }

        public virtual DbSet<cursos> cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
