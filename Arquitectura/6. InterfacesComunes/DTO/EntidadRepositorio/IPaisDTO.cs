using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesComunes.DTO
{
    public interface IPaisDTO
    {
        int IdPais { get; set; }
        string CodigoPais { get; set; }
        string NombrePais { get; set; }
        bool? EstadoPais { get; set; }
        byte[] Version { get; set; }
    }
}
