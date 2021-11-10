using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RDLCDesign
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Academia")
        {
        }

        public virtual DbSet<especialidade> especialidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<especialidade>()
                .Property(e => e.desc_especialidad)
                .IsUnicode(false);
        }
    }
}
