using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;

namespace Infotrack.Base.IC.Acciones.Entidades
{
    public interface ICursoMateriaAcciones
    {
        Respuesta<ICursoMateriaDTO> AgregarNota(ICursoMateriaDTO cursoMateriaDTO);

        Respuesta<ICursoMateriaDTO> ActualizarNota(ICursoMateriaDTO cursoMateriaDTO);

        Respuesta<ICursoMateriaDTO> EliminarNotaPorID(int idCursoMateria);

        Respuesta<ICursoMateriaDTO> ConsultarNotas();

        Respuesta<ICursoMateriaDTO> ConsultarNotaPorID(int idCursoMateria);
    }
}