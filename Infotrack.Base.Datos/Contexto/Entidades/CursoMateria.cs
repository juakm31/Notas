namespace Infotrack.Base.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CursoMateria")]
    public partial class CursoMateria
    {
        [Key]
        public int Id_CursoMateria { get; set; }

        public int Id_Materia { get; set; }

        public int Id_Curso { get; set; }

        public virtual Curso Curso { get; set; }

        public virtual Materia Materia { get; set; }
    }
}
