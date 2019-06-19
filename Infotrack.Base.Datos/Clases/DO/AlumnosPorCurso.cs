using Infotrack.Base.IC.DTO.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Datos.Clases.DO
{
    public class AlumnosPorCurso : IAlumnoPorCursoDTO
    {
        public string NombreCurso { get; set; }
        public List<string> ListAlumnos { get; set; }
    }
}
