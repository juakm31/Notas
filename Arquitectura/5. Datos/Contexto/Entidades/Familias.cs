namespace Datos.Contexto.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("inv.Familias")]
    public partial class Familias
    {
        [Key]
        public int FamiliaId { get; set; }

        public Guid EmpresaId { get; set; }

        [Required]
        [StringLength(250)]
        public string FamiliaDescripcion { get; set; }
    }
}
