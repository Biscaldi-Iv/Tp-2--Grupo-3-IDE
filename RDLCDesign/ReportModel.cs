using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RDLCDesign
{
    public partial class ReportModel : DbContext
    {
        public ReportModel()
            : base("name=ReportModel")
        {
        }

        public virtual DbSet<cursos> cursos { get; set; }
        public virtual DbSet<planes> planes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<planes>()
                .Property(e => e.desc_plan)
                .IsUnicode(false);
        }
    }
}
