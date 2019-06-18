using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.IC.Acciones.Entidades
{
    interface IAlumnoAction
    {
        Respuesta<IAlumnoDTO> ConsultarAlumnos();
        Respuesta<IAlumnoDTO> ConsultarAlumnoId(int id);
        Respuesta<IAlumnoDTO> AgregarAlumno(IAlumnoDTO alumnoDTO);
        Respuesta<IAlumnoDTO> ActualizarAlumno(IAlumnoDTO alumnoDTO);
        Respuesta<IAlumnoDTO> EliminarAlumno(IAlumnoDTO alumnoDTO);
    }
}
