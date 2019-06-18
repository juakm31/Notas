using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.IC.Acciones.Entidades
{
    interface ICursoAction
    {
        Respuesta<ICursoDTO> ConsultarCursos();
        Respuesta<ICursoDTO> ConsultarCursoId(int id);
        Respuesta<ICursoDTO> AgregarCurso(ICursoDTO cursoDTO);
        Respuesta<ICursoDTO> ActualizarCurso(ICursoDTO cursoDTO);
        Respuesta<ICursoDTO> EliminarCurso(ICursoDTO cursoDTO);
    }
}
