using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using InterfacesComunes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesComunes.Acciones
{
    public interface ITiposUnidadesAcciones
    {
        Respuesta<ITiposUnidadesDTO> ConsultarTiposUnidades();
        Respuesta<ITiposUnidadesDTO> ConsultarTipoUnidadesId(int id);
        Respuesta<ITiposUnidadesDTO> AgregarTipoUnidades(ITiposUnidadesDTO tiposUnidadesDTO);
        Respuesta<ITiposUnidadesDTO> ActualizarTiposUnidades(ITiposUnidadesDTO tiposUnidadesDTO);
        Respuesta<ITiposUnidadesDTO> EliminarTipoUnidad(ITiposUnidadesDTO tiposUnidadesDTO);
    }
}
