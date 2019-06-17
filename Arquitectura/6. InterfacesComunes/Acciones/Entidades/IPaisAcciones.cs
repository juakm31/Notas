using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using InterfacesComunes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesComunes.Acciones
{
    public interface IPaisAcciones
    {
        Respuesta<IPaisDTO> ConsultarPais();
        Respuesta<IPaisDTO> ConsultarPaisId(int id);
        Respuesta<IPaisDTO> AgregarPais(IPaisDTO paisDTO);
        Respuesta<IPaisDTO> ActualizarPais(IPaisDTO paisDTO);
        Respuesta<IPaisDTO> EliminarPais(IPaisDTO paisDTO);
    }
}
