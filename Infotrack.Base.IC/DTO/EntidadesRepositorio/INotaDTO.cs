namespace Infotrack.Base.IC.DTO.EntidadesRepositorio
{
    public interface INotaDTO
    {
        int Id_Nota { get; set; }

        int Id_Curso { get; set; }

        int Id_Materia { get; set; }

        int Id_Alumno { get; set; }

        double Nota1 { get; set; }

        //IAlumnoDTO Alumno { get; set; }

        //ICursoDTO Curso { get; set; }

        //IMateriaDTO Materia { get; set; }
    }
}