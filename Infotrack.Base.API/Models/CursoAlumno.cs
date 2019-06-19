using Infotrack.Base.IC.DTO.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infotrack.Base.API.Models
{
    public class CursoAlumno : IAlumnoPorCursoDTO
    {
        public string NombreCurso { get; set; }
        public List<string> ListAlumnos { get; set; }
    }
}