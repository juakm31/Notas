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
    public class AlumnoDAL : AccesoComunDAL<DatosContexto>, IAlumnoAction
    {
        Respuesta<IAlumnoDTO> Respuesta;
        RepositorioGenerico<Alumno> Repositorio;

        public AlumnoDAL()
        {
            Respuesta = new Respuesta<IAlumnoDTO>();
            Repositorio = new RepositorioGenerico<Alumno>(ContextoBD);
        }

        public Respuesta<IAlumnoDTO> ActualizarAlumno(IAlumnoDTO alumnoDTO)
        {
            throw new NotImplementedException();
        }

        public Respuesta<IAlumnoDTO> AgregarAlumno(IAlumnoDTO alumnoDTO)
        {
            throw new NotImplementedException();
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
