using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.IC.DTO.Consultas
{
    public interface IFiltroNotaDTO
    {
        int IdCurso { get; set; }
        int IdMateria { get; set; }
        int IdAlumno { get; set; }
        string NombreCurso { get; set; }
        string NombreMateria { get; set; }
        string NombreAlumno { get; set; }
        string Nota { get; set; }
        string correo { get; set; }
    }
}
