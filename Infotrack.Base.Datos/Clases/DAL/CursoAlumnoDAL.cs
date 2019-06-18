using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.IC.App_LocalResources;
using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Transaccional.EF.Clases;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using Infotrack.Utilitarios.Clases.Mapeador.Extensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Datos.DAL
{
    public class CursoAlumnoDAL : AccesoComunDAL<DatosContexto>, ICursoAlumnoAcciones
    {
        Respuesta<ICursoAlumnoDTO> Respuesta;
        RepositorioGenerico<CursoAlumno> RepositorioCursoAlumno;

        public CursoAlumnoDAL()
        {
            Respuesta = new Respuesta<ICursoAlumnoDTO>();
            RepositorioCursoAlumno = new RepositorioGenerico<CursoAlumno>(ContextoBD);
        }

        public Respuesta<ICursoAlumnoDTO> ActualizarCursoAlumno(ICursoAlumnoDTO cursoAlumnoDTO)
        {
            return EjecutarTransaccion<Respuesta<ICursoAlumnoDTO>, CursoAlumnoDAL>(() =>
            {
                CursoAlumno cursoAlumno = (RepositorioCursoAlumno.BuscarPor(entidad => entidad.Id_CursoAlumno == cursoAlumnoDTO.Id_CursoAlumno).FirstOrDefault());
                RepositorioCursoAlumno.Editar(cursoAlumno);
                RepositorioCursoAlumno.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.ActualizacionExitosa);
                return Respuesta;
            });
        }

        public Respuesta<ICursoAlumnoDTO> AgregarCursoAlumno(ICursoAlumnoDTO cursoAlumnoDTO)
        {
            return EjecutarTransaccion<Respuesta<ICursoAlumnoDTO>, CursoAlumnoDAL>(() =>
            {
                CursoAlumno CursoAlumnoEntidad = Mapeador.MapearEntidadDTO(cursoAlumnoDTO, new CursoAlumno());
                RepositorioCursoAlumno.Agregar(CursoAlumnoEntidad);
                RepositorioCursoAlumno.Guardar();
                Respuesta.Resultado = true;
                Respuesta.Mensajes.Add(MensajesComunes.MensajeCreacionExitosa);
                Respuesta.Entidades.Add(CursoAlumnoEntidad);
                //Respuesta.TipoNotificacion;
                return Respuesta;
            });
        }

        public Respuesta<ICursoAlumnoDTO> ConsultarCursoAlumno()
        {
            return EjecutarTransaccion<Respuesta<ICursoAlumnoDTO>, CursoAlumnoDAL>(() =>
            {
                Respuesta.Entidades = RepositorioCursoAlumno.BuscarTodos().ToList<ICursoAlumnoDTO>();
                return Respuesta;

            });
        }

        public Respuesta<ICursoAlumnoDTO> ConsultarCursoAlumnoPorID(int idCursoAlumno)
        {
            return EjecutarTransaccion<Respuesta<ICursoAlumnoDTO>, CursoAlumnoDAL>(() =>
            {

                Respuesta.Entidades = RepositorioCursoAlumno.BuscarPor(entidad => entidad.Id_Alumno == idCursoAlumno).ToList<ICursoAlumnoDTO>();
                return Respuesta;
            });
        }

        public Respuesta<ICursoAlumnoDTO> EliminarCursoAlumnoPorID(int idCursoAlumno)
        {
            return EjecutarTransaccion<Respuesta<ICursoAlumnoDTO>, CursoAlumnoDAL>(() => {
                CursoAlumno alumno = (RepositorioCursoAlumno.BuscarPor(entidad => entidad.Id_Alumno == idCursoAlumno).FirstOrDefault());
                RepositorioCursoAlumno.Eliminar(alumno);
                RepositorioCursoAlumno.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }
    }
}
