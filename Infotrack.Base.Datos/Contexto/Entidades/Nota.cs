namespace Infotrack.Base.Datos
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Nota")]
    public partial class Nota
    {
        [Key]
        public int Id_Nota { get; set; }

        public int Id_Curso { get; set; }

        public int Id_Materia { get; set; }

        public int Id_Alumno { get; set; }

        [Column("Nota")]
        public double Nota1 { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Curso Curso { get; set; }

        public virtual Materia Materia { get; set; }
    }
}