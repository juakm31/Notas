namespace Infotrack.Base.Datos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatosContexto : DbContext
    {
        

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
