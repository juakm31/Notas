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
    public class CursoMateriaBL : AccesoComunBL, ICursoMateriaAcciones
    {
        private Lazy<ICursoMateriaAcciones> RepositorioCursoAlumno;
        private Respuesta<ICursoMateriaAcciones> RespuestaCursoAlumno;

        public CursoMateriaBL(Lazy<ICursoMateriaAcciones> repositorioCursoAlumno)
        {
            RepositorioCursoAlumno = repositorioCursoAlumno;
            RespuestaCursoAlumno = new Respuesta<ICursoMateriaAcciones>();
        }

        public Respuesta<ICursoMateriaDTO> ActualizarCursoMateria(ICursoMateriaDTO cursoMateriaDTO)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoMateriaDTO>, MateriaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCursoAlumno.Value.ActualizarCursoMateria(cursoMateriaDTO);
            });
        }

        public Respuesta<ICursoMateriaDTO> AgregarCursoMateria(ICursoMateriaDTO cursoMateriaDTO)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoMateriaDTO>, MateriaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCursoAlumno.Value.AgregarCursoMateria(cursoMateriaDTO);
            });
        }

        public Respuesta<ICursoMateriaDTO> ConsultarCursoMateria()
        {
            return EjecutarTransaccionBD<Respuesta<ICursoMateriaDTO>, MateriaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCursoAlumno.Value.ConsultarCursoMateria();
            });
        }

        public Respuesta<ICursoMateriaDTO> ConsultarCursoMateriaPorID(int idCursoMateria)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoMateriaDTO>, MateriaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCursoAlumno.Value.ConsultarCursoMateriaPorID(idCursoMateria);
            });
        }

        public Respuesta<ICursoMateriaDTO> EliminarCursoMateriaPorID(int idCursoMateria)
        {
            return EjecutarTransaccionBD<Respuesta<ICursoMateriaDTO>, MateriaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioCursoAlumno.Value.EliminarCursoMateriaPorID(idCursoMateria);
            });
        }
    }
}
