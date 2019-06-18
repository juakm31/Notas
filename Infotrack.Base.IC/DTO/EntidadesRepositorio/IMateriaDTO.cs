using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.IC.DTO.EntidadesRepositorio
{
    public interface IMateriaDTO
    {
        int Id_Materia { get; set; }
        string Nombre { get; set; }
        string Estado { get; set; }
    }
}
