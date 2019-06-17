using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using InterfacesComunes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesComunes.Acciones
{
    public interface IFamiliasAcciones
    {
        Respuesta<IFamiliasDTO> ConsultarFamilias();
        Respuesta<IFamiliasDTO> ConsultarFamiliaId(int id);
        Respuesta<IFamiliasDTO> AgregarFamilia(IFamiliasDTO familiasDTO);
        Respuesta<IFamiliasDTO> ActualizarFamilias(IFamiliasDTO familiasDTO);
        Respuesta<IFamiliasDTO> EliminarFamilia(IFamiliasDTO familiasDTO);
    }
}
