using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesComunes.DTO
{
    public interface ITiposUnidadesDTO
    {
        int TipoUnidadId { get; set; }
        Guid EmpresaId { get; set; }
        string DescripcionTipoUnidad { get; set; }
    }
}
