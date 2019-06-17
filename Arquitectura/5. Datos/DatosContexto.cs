namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Datos.Contexto.Entidades;

    public partial class DatosContexto : DbContext
    {

        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<TiposUnidades> TiposUnidades { get; set; }
        public virtual DbSet<Familias> Familias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>()
                .Property(e => e.CodigoPais)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .Property(e => e.NombrePais)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<TiposUnidades>()
                .Property(e => e.DescripcionTipoUnidad)
                .IsUnicode(false);

            modelBuilder.Entity<Familias>()
                .Property(e => e.FamiliaDescripcion)
                .IsUnicode(false);
        }
    }
}
