using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Transaccional.EF.Clases;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Negocio.Clases.BL
{
    public class MateriaBL : AccesoComunBL, IMateriaAction
    {
        private Lazy<IMateriaAction> RepositorioCurso;
        private Respuesta<IMateriaAction> RespuestaCurso;

        public MateriaBL(Lazy<IMateriaAction> repositorioCurso)
        {
            RepositorioCurso = repositorioCurso;
            RespuestaCurso = new Respuesta<IMateriaAction>();
        }
        public Respuesta<IMateriaDTO> ActualizarMateria(IMateriaDTO materiaDTO)
        {
            return EjecutarTransaccionBD<Respuesta<IMateriaDTO>, MateriaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCurso.Value.ActualizarMateria(materiaDTO);
            });
        }

        public Respuesta<IMateriaDTO> AgregarMateria(IMateriaDTO materiaDTO)
        {
            return EjecutarTransaccionBD<Respuesta<IMateriaDTO>, MateriaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCurso.Value.AgregarMateria(materiaDTO);
            });
        }

        public Respuesta<IMateriaDTO> ConsultarMateriaId(int id)
        {
            return EjecutarTransaccionBD<Respuesta<IMateriaDTO>, MateriaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCurso.Value.ConsultarMateriaId(id);
            });
        }

        public Respuesta<IMateriaDTO> ConsultarMaterias()
        {
            return EjecutarTransaccionBD<Respuesta<IMateriaDTO>, MateriaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCurso.Value.ConsultarMaterias();
            });
        }

        public Respuesta<IMateriaDTO> EliminarMateria(IMateriaDTO materiaDTO)
        {
            return EjecutarTransaccionBD<Respuesta<IMateriaDTO>, MateriaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCurso.Value.EliminarMateria(materiaDTO);
            });
        }
    }
}
