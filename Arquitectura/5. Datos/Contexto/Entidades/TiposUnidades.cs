namespace Datos.Contexto.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fw.TiposUnidades")]
    public partial class TiposUnidades
    {
        [Key]
        public int TipoUnidadId { get; set; }

        public Guid EmpresaId { get; set; }

        [Required]
        [StringLength(120)]
        public string DescripcionTipoUnidad { get; set; }
    }
}
