using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;

namespace Infotrack.Base.IC.Acciones.Entidades
{
    public interface ICursoAlumnoAcciones
    {
        Respuesta<ICursoAlumnoDTO> AgregarCursoAlumno(ICursoAlumnoDTO cursoAlumnoDTO);

        Respuesta<ICursoAlumnoDTO> ActualizarCursoAlumno(ICursoAlumnoDTO cursoAlumnoDTO);

        Respuesta<ICursoAlumnoDTO> EliminarCursoAlumnoPorID(int idcursoAlumno);

        Respuesta<ICursoAlumnoDTO> ConsultarCursoAlumno();

        Respuesta<ICursoAlumnoDTO> ConsultarCursoAlumnoPorID(int idcursoAlumno);
    }
}