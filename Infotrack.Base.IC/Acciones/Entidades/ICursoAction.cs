using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;

namespace Infotrack.Base.IC.Acciones.Entidades
{
    public interface ICursoAction
    {
        Respuesta<ICursoDTO> ConsultarCursos();

        Respuesta<ICursoDTO> ConsultarCursoId(int id);

        Respuesta<ICursoDTO> AgregarCurso(ICursoDTO cursoDTO);

        Respuesta<ICursoDTO> ActualizarCurso(ICursoDTO cursoDTO);

        Respuesta<ICursoDTO> EliminarCurso(ICursoDTO cursoDTO);
    }
}