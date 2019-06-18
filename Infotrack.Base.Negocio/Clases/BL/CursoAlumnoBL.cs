using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Transaccional.EF.Clases;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Negocio.Clases
{
    public class CursoAlumnoBL : AccesoComunBL, ICursoAlumnoAcciones
    {
        private Lazy<ICursoAlumnoAcciones> RepositorioCursoAlumno;
        private Respuesta<ICursoAlumnoAcciones> RespuestaCursoAlumno;

        public CursoAlumnoBL(Lazy<ICursoAlumnoAcciones> repositorioCursoAlumno)
        {
            RepositorioCursoAlumno = repositorioCursoAlumno;
            RespuestaCursoAlumno = new Respuesta<ICursoAlumnoAcciones>();
        }
        public Respuesta<ICursoAlumnoDTO> ActualizarCursoAlumno(ICursoAlumnoDTO cursoAlumnoDTO)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoAlumnoDTO>, CursoAlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCursoAlumno.Value.ActualizarCursoAlumno(cursoAlumnoDTO);
            });
        }

        public Respuesta<ICursoAlumnoDTO> AgregarCursoAlumno(ICursoAlumnoDTO cursoAlumnoDTO)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoAlumnoDTO>, CursoAlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCursoAlumno.Value.AgregarCursoAlumno(cursoAlumnoDTO);
            });
        }

        public Respuesta<ICursoAlumnoDTO> ConsultarCursoAlumno()
        {
            return EjecutarTransaccionBD<Respuesta<ICursoAlumnoDTO>, CursoAlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCursoAlumno.Value.ConsultarCursoAlumno();
            });
        }

        public Respuesta<ICursoAlumnoDTO> ConsultarCursoAlumnoPorID(int idcursoAlumno)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoAlumnoDTO>, CursoAlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCursoAlumno.Value.ConsultarCursoAlumnoPorID(idcursoAlumno);
            });
        }

        public Respuesta<ICursoAlumnoDTO> EliminarCursoAlumnoPorID(int idcursoAlumno)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoAlumnoDTO>, CursoAlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCursoAlumno.Value.EliminarCursoAlumnoPorID(idcursoAlumno);
            });
        }
    }
}
