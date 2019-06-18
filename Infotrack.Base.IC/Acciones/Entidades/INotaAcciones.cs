using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;

namespace Infotrack.Base.IC.Acciones.Entidades
{
    public interface INotaAcciones
    {
        Respuesta<INotaDTO> AgregarNota(INotaDTO notaDTO);

        Respuesta<INotaDTO> ActualizarNota(INotaDTO notaDTO);

        Respuesta<INotaDTO> EliminarNotaPorID(int idNota);

        Respuesta<INotaDTO> ConsultarNotas();

        Respuesta<INotaDTO> ConsultarNotaPorID(int idNota);
    }
}