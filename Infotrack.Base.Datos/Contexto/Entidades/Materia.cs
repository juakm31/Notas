namespace Infotrack.Base.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Materia")]
    public partial class Materia
    {
        [Key]
        public int Id_Materia { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(20)]
        public string Estado { get; set; }
    }
}
