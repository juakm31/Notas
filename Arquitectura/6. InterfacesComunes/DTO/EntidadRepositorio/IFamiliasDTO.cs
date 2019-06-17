using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesComunes.DTO
{
    public interface IFamiliasDTO
    {
        int FamiliaId { get; set; }
        Guid EmpresaId { get; set; }
        string FamiliaDescripcion { get; set; }
    }
}
