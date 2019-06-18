namespace Infotrack.Base.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Curso")]
    public partial class Curso
    {
        [Key]
        public int Id_Curso { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(20)]
        public string Estado { get; set; }
    }
}
