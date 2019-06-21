using Infotrack.Base.IC.DTO.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infotrack.Base.API.Models
{
    public class FiltroNota : IFiltroNotaDTO
    {
        public int IdCurso { get ; set ; }
        public int IdMateria { get ; set ; }
        public int IdAlumno { get ; set ; }
        public string NombreCurso { get ; set ; }
        public string NombreMateria { get ; set ; }
        public string NombreAlumno { get ; set ; }
        public string Nota { get ; set ; }
        public string correo { get ; set ; }
    }
}