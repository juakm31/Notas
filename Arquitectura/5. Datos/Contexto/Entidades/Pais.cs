namespace Datos.Contexto.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("adm.Pais")]
    public partial class Pais
    {
        [Key]
        public int IdPais { get; set; }

        [Required]
        [StringLength(10)]
        public string CodigoPais { get; set; }

        [Required]
        [StringLength(100)]
        public string NombrePais { get; set; }

        public bool? EstadoPais { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Version { get; set; }
    }
}
