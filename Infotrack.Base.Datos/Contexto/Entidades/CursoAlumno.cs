namespace Infotrack.Base.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CursoAlumno")]
    public partial class CursoAlumno
    {
        [Key]
        public int Id_CursoAlumno { get; set; }

        public int Id_Alumno { get; set; }

        public int Id_Curso { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Curso Curso { get; set; }
    }
}
