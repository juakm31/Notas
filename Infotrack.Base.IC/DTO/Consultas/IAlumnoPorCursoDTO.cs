using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.IC.DTO.Consultas
{
    public interface IAlumnoPorCursoDTO
    {
        string NombreCurso { get; set; }
        List<string> ListAlumnos { get; set; }
    }
}
