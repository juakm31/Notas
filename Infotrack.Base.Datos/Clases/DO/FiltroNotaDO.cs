using Infotrack.Base.IC.DTO.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Datos.Clases.DO
{
    public class FiltroNotaDO : IFiltroNotaDTO
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
