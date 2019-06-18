using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.IC.Acciones.Entidades
{
    interface IMateriaAction
    {
        Respuesta<IMateriaDTO> ConsultarMaterias();
        Respuesta<IMateriaDTO> ConsultarMateriaId(int id);
        Respuesta<IMateriaDTO> AgregarMateria(IMateriaDTO materiaDTO);
        Respuesta<IMateriaDTO> ActualizarMateria(IMateriaDTO materiaDTO);
        Respuesta<IMateriaDTO> EliminarMateria(IMateriaDTO materiaDTO);
    }
}
