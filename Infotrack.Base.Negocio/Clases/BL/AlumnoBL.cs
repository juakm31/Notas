using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Transaccional.EF.Clases;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using System;

namespace Infotrack.Base.Negocio.Clases.BL
{
    public class AlumnoBL : AccesoComunBL, IAlumnoAction
    {
        private Lazy<IAlumnoAction> RepositorioAlumno;
        private Respuesta<IAlumnoAction> RespuestaAlumno;

        public AlumnoBL(Lazy<IAlumnoAction> repositorioAlumno)
        {
            RepositorioAlumno = repositorioAlumno;
            RespuestaAlumno = new Respuesta<IAlumnoAction>();
        }

        public Respuesta<IAlumnoDTO> ActualizarAlumno(IAlumnoDTO alumnoDTO)
        {
            return EjecutarTransaccionBD<Respuesta<IAlumnoDTO>, AlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioAlumno.Value.ActualizarAlumno(alumnoDTO);
            });
        }

        public Respuesta<IAlumnoDTO> AgregarAlumno(IAlumnoDTO alumnoDTO)
        {
            return EjecutarTransaccionBD<Respuesta<IAlumnoDTO>, AlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioAlumno.Value.AgregarAlumno(alumnoDTO);
            });
        }

        public Respuesta<IAlumnoDTO> ConsultarAlumnoId(int id)
        {
            return EjecutarTransaccionBD<Respuesta<IAlumnoDTO>, AlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioAlumno.Value.ConsultarAlumnoId(id);
            });
        }

        public Respuesta<IAlumnoDTO> ConsultarAlumnos()
        {
            return EjecutarTransaccionBD<Respuesta<IAlumnoDTO>, AlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                 return RepositorioAlumno.Value.ConsultarAlumnos();
            });
        }

        public Respuesta<IAlumnoDTO> EliminarAlumno(IAlumnoDTO alumnoDTO)
        {
            return EjecutarTransaccionBD<Respuesta<IAlumnoDTO>, AlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioAlumno.Value.EliminarAlumno(alumnoDTO);
            });
        }
    }
}
