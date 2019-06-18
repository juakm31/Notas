namespace Infotrack.Base.IC.DTO.EntidadesRepositorio
{
    public interface ICursoMateriaDTO
    {
        int Id_CursoMateria { get; set; }

        int Id_Materia { get; set; }

        int Id_Curso { get; set; }

        ICursoDTO Curso { get; set; }

        IMateriaDTO Materia { get; set; }
    }
}