using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;

namespace Infotrack.Base.IC.Acciones.Entidades
{
    public interface ICursoAlumnoAcciones
    {
        Respuesta<ICursoAlumnoDTO> AgregarNota(ICursoAlumnoDTO cursoAlumnoDTO);

        Respuesta<ICursoAlumnoDTO> ActualizarNota(ICursoAlumnoDTO cursoAlumnoDTO);

        Respuesta<ICursoAlumnoDTO> EliminarNotaPorID(int idcursoAlumno);

        Respuesta<ICursoAlumnoDTO> ConsultarNotas();

        Respuesta<ICursoAlumnoDTO> ConsultarNotaPorID(int idcursoAlumno);
    }
}