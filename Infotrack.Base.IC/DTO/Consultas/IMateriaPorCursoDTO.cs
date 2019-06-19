using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.IC.DTO.EntidadesRepositorio
{
    public interface IMateriaPorCursoDTO
    {
        string NombreCurso { get; set; }
        List<string> ListaMaterias { get; set; }
    }
}
