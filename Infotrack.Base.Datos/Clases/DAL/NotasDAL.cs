using Infotrack.Base.Datos.Clases.DO;
using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.IC.App_LocalResources;
using Infotrack.Base.IC.DTO.Consultas;
using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Transaccional.EF.Clases;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using Infotrack.Utilitarios.Clases.Mapeador.Extensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Datos.Clases.DAL
{
    public class NotasDAL : AccesoComunDAL<DatosContexto>, INotaAcciones
    {
        Respuesta<INotaDTO> Respuesta;
        RepositorioGenerico<Nota> RepositorioNotas;

        public NotasDAL()
        {
            Respuesta = new Respuesta<INotaDTO>();
            RepositorioNotas = new RepositorioGenerico<Nota>(ContextoBD);
        }

        public Respuesta<INotaDTO> ActualizarNota(INotaDTO notaDTO)
        {
            Nota nota = (RepositorioNotas.BuscarPor(entidad => entidad.Id_Nota == notaDTO.Id_Nota).FirstOrDefault());
            RepositorioNotas.Editar(nota);
            RepositorioNotas.Guardar();
            Respuesta.Mensajes.Add(MensajesComunes.ActualizacionExitosa);

            return Respuesta;
        }

        public Respuesta<INotaDTO> AgregarNota(INotaDTO notaDTO)
        {
            return EjecutarTransaccion<Respuesta<INotaDTO>, NotasDAL>(() =>
            {
                Nota nota = Mapeador.MapearEntidadDTO(notaDTO, new Nota());
                RepositorioNotas.Agregar(nota);
                RepositorioNotas.Guardar();
                Respuesta.Resultado = true;
                Respuesta.Mensajes.Add(MensajesComunes.MensajeCreacionExitosa);
                Respuesta.Entidades.Add(nota);
                //Respuesta.TipoNotificacion = "";

                return Respuesta;
            });
        }

        public Respuesta<INotaDTO> ConsultarNotaPorID(int idNota)
        {
            return EjecutarTransaccion<Respuesta<INotaDTO>, NotasDAL>(() =>
            {

                Respuesta.Entidades = RepositorioNotas.BuscarPor(entidad => entidad.Id_Nota == idNota).ToList<INotaDTO>();
                return Respuesta;
            });
        }

        public Respuesta<INotaDTO> ConsultarNotas()
        {
            return EjecutarTransaccion<Respuesta<INotaDTO>, NotasDAL>(() =>
            {
                Respuesta.Entidades = RepositorioNotas.BuscarTodos().ToList<INotaDTO>();
                return Respuesta;

            });
        }

        public Respuesta<INotaDTO> EliminarNotaPorID(int idNota)
        {
            return EjecutarTransaccion<Respuesta<INotaDTO>, NotasDAL>(() => {
                Nota nota = (RepositorioNotas.BuscarPor(entidad => entidad.Id_Nota == idNota).FirstOrDefault());
                RepositorioNotas.Eliminar(nota);
                RepositorioNotas.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }

        public Respuesta<IFiltroNotaDTO> FiltroNota(INotaDTO notaDTO)
        {
            return EjecutarTransaccion<Respuesta<IFiltroNotaDTO>, NotasDAL>(() =>
            {
                Respuesta<IFiltroNotaDTO> respuestaFiltro = new Respuesta<IFiltroNotaDTO>();
                respuestaFiltro.Entidades = (from nota in ContextoBD.Nota
                                       join curso in ContextoBD.Curso on nota.Id_Curso equals curso.Id_Curso
                                       join materia in ContextoBD.Materia on nota.Id_Materia equals materia.Id_Materia
                                       join alumno in ContextoBD.Alumno on nota.Id_Alumno equals alumno.Id_Alumno
                                       where notaDTO.Id_Curso > 0 ? curso.Id_Curso == notaDTO.Id_Curso : true
                                       where notaDTO.Id_Materia > 0 ? materia.Id_Materia == notaDTO.Id_Materia :  true
                                       where notaDTO.Id_Alumno > 0 ? alumno.Id_Alumno == notaDTO.Id_Alumno : true
                                       select new FiltroNotaDO {
                                           IdCurso = curso.Id_Curso,
                                           IdMateria = materia.Id_Materia,
                                           IdAlumno = alumno.Id_Alumno,
                                           NombreCurso = curso.Nombre,
                                           NombreMateria = materia.Nombre,
                                           NombreAlumno = alumno.Nombre + " " + alumno.Apellido,
                                           correo = alumno.Correo,
                                           Nota = nota.Nota1 + ""
                                       }).ToList<IFiltroNotaDTO>();

                return respuestaFiltro;
            });
        }
    }
}
