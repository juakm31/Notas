using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;

namespace Infotrack.Base.IC.Acciones.Entidades
{
    public interface IAlumnoAction
    {
        Respuesta<IAlumnoDTO> ConsultarAlumnos();

        Respuesta<IAlumnoDTO> ConsultarAlumnoId(int id);

        Respuesta<IAlumnoDTO> AgregarAlumno(IAlumnoDTO alumnoDTO);

        Respuesta<IAlumnoDTO> ActualizarAlumno(IAlumnoDTO alumnoDTO);

        Respuesta<IAlumnoDTO> EliminarAlumno(IAlumnoDTO alumnoDTO);
    }
}