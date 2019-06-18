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
            return EjecutarTransaccion<Respuesta<IAlumnoDTO>, AlumnoDAL>(() =>
            {
                Alumno alumno = (Repositorio.BuscarPor(entidad => entidad.Id_Alumno == alumnoDTO.Id_Alumno).FirstOrDefault());
                Repositorio.Editar(alumno);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }

        public Respuesta<IAlumnoDTO> AgregarAlumno(IAlumnoDTO alumnoDTO)
        {
            return EjecutarTransaccion<Respuesta<IAlumnoDTO>, AlumnoDAL>(() =>
            {
                Alumno alumno = new Alumno
                {
                    Id_Alumno = alumnoDTO.Id_Alumno,
                    Nombre = alumnoDTO.Nombre,
                    Apellido = alumnoDTO.Apellido,
                    Correo = alumnoDTO.Correo,
                    Estado = alumnoDTO.Estado
                };
                Repositorio.Agregar(alumno);
                Repositorio.Guardar();
                return Respuesta;
            });
        }

        public Respuesta<IAlumnoDTO> ConsultarAlumnoId(int id)
        {
            return EjecutarTransaccion<Respuesta<IAlumnoDTO>, AlumnoDAL>(() =>
            {

                Respuesta.Entidades = Repositorio.BuscarPor(entidad => entidad.Id_Alumno == id).ToList<IAlumnoDTO>();
                return Respuesta;
            });
        }

        public Respuesta<IAlumnoDTO> ConsultarAlumnos()
        {
            return EjecutarTransaccion<Respuesta<IAlumnoDTO>, AlumnoDAL>(() =>
            {
                Respuesta.Entidades = Repositorio.BuscarTodos().ToList<IAlumnoDTO>();
                return Respuesta;

            });
        }

        public Respuesta<IAlumnoDTO> EliminarAlumno(IAlumnoDTO alumnoDTO)
        {
            return EjecutarTransaccion<Respuesta<IAlumnoDTO>, AlumnoDAL>(() => {
                Alumno alumno = (Repositorio.BuscarPor(entidad => entidad.Id_Alumno == alumnoDTO.Id_Alumno).FirstOrDefault());
                Repositorio.Eliminar(alumno);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }
    }
}
