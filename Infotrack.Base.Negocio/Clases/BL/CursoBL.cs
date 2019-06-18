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
    public class CursoBL : AccesoComunBL, ICursoAction
    {
        private Lazy<ICursoAction> RepositorioCurso;
        private Respuesta<ICursoAction> RespuestaCurso;

        public CursoBL(Lazy<ICursoAction> repositorioCurso)
        {
            RepositorioCurso = repositorioCurso;
            RespuestaCurso = new Respuesta<ICursoAction>();
        }

        public Respuesta<ICursoDTO> ActualizarCurso(ICursoDTO cursoDTO)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoDTO>, CursoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCurso.Value.ActualizarCurso(cursoDTO);
            });
        }

        public Respuesta<ICursoDTO> AgregarCurso(ICursoDTO cursoDTO)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoDTO>, CursoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCurso.Value.AgregarCurso(cursoDTO);
            });
        }

        public Respuesta<ICursoDTO> ConsultarCursoId(int id)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoDTO>, CursoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCurso.Value.ConsultarCursoId(id);
            });
        }

        public Respuesta<ICursoDTO> ConsultarCursos()
        {
            return EjecutarTransaccionBD<Respuesta<ICursoDTO>, CursoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCurso.Value.ConsultarCursos();
            });
        }

        public Respuesta<ICursoDTO> EliminarCurso(ICursoDTO cursoDTO)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoDTO>, CursoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCurso.Value.EliminarCurso(cursoDTO);
            });
        }
    }
}
