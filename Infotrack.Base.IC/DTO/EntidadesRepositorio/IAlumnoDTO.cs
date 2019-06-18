using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.IC.DTO.EntidadesRepositorio
{
    public interface IAlumnoDTO
    {
        int Id_Alumno { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Correo { get; set; }
        string Estado { get; set; }
    }
}
