using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;

namespace Infotrack.Base.IC.Acciones.Entidades
{
    public interface ICursoMateriaAcciones
    {
        Respuesta<ICursoMateriaDTO> AgregarCursoMateria(ICursoMateriaDTO cursoMateriaDTO);

        Respuesta<ICursoMateriaDTO> ActualizarCursoMateria(ICursoMateriaDTO cursoMateriaDTO);

        Respuesta<ICursoMateriaDTO> EliminarCursoMateriaPorID(int idCursoMateria);

        Respuesta<ICursoMateriaDTO> ConsultarCursoMateria();

        Respuesta<ICursoMateriaDTO> ConsultarCursoMateriaPorID(int idCursoMateria);
    }
}