using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;

namespace Infotrack.Base.IC.Acciones.Entidades
{
    public interface IMateriaAction
    {
        Respuesta<IMateriaDTO> ConsultarMaterias();

        Respuesta<IMateriaDTO> ConsultarMateriaId(int id);

        Respuesta<IMateriaDTO> AgregarMateria(IMateriaDTO materiaDTO);

        Respuesta<IMateriaDTO> ActualizarMateria(IMateriaDTO materiaDTO);

        Respuesta<IMateriaDTO> EliminarMateria(IMateriaDTO materiaDTO);
    }
}