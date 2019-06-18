namespace Infotrack.Base.Datos
{
    using System.Data.Entity;

    public partial class DatosContexto : DbContext
    {
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<CursoAlumno> CursoAlumno { get; set; }
        public virtual DbSet<CursoMateria> CursoMateria { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Nota> Nota { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Nota)
                .WithRequired(e => e.Alumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.CursoMateria)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Nota)
                .WithRequired(e => e.Curso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materia>()
                .HasMany(e => e.CursoMateria)
                .WithRequired(e => e.Materia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materia>()
                .HasMany(e => e.Nota)
                .WithRequired(e => e.Materia)
                .WillCascadeOnDelete(false);
        }
    }
}