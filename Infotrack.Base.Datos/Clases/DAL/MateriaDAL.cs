using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Transaccional.EF.Clases;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Datos.Clases.DAL
{
    class MateriaDAL : AccesoComunDAL<DatosContexto>, IMateriaAction
    {
        Respuesta<IMateriaDTO> Respuesta;
        RepositorioGenerico<Materia> Repositorio;

        public MateriaDAL()
        {
            Respuesta = new Respuesta<IMateriaDTO>();
            Repositorio = new RepositorioGenerico<Materia>(ContextoBD);
        }

        public Respuesta<IMateriaDTO> ActualizarMateria(IMateriaDTO materiaDTO)
        {
            throw new NotImplementedException();
        }

        public Respuesta<IMateriaDTO> AgregarMateria(IMateriaDTO materiaDTO)
        {
            throw new NotImplementedException();
        }

        public Respuesta<IMateriaDTO> ConsultarMateriaId(int id)
        {
            throw new NotImplementedException();
        }

        public Respuesta<IMateriaDTO> ConsultarMaterias()
        {
            throw new NotImplementedException();
        }

        public Respuesta<IMateriaDTO> EliminarMateria(IMateriaDTO materiaDTO)
        {
            throw new NotImplementedException();
        }
    }
}
