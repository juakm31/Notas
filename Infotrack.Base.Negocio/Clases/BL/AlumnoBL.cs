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
            return EjecutarTransaccionBD<Respuesta<IAlumnoAction>, AlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {

                return RepositorioAlumno.Value.ActualizarAlumno(alumnoDTO);
            });
        }

        public Respuesta<IAlumnoDTO> AgregarAlumno(IAlumnoDTO alumnoDTO)
        {
            return EjecutarTransaccionBD<Respuesta<IAlumnoAction>, AlumnoBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {

            });
        }

        public Respuesta<IAlumnoDTO> ConsultarAlumnoId(int id)
        {
            throw new NotImplementedException();
        }

        public Respuesta<IAlumnoDTO> ConsultarAlumnos()
        {
            throw new NotImplementedException();
        }

        public Respuesta<IAlumnoDTO> EliminarAlumno(IAlumnoDTO alumnoDTO)
        {
            throw new NotImplementedException();
        }
    }
}
