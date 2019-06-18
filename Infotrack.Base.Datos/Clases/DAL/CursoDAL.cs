using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.IC.App_LocalResources;
using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Transaccional.EF.Clases;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using Infotrack.Utilitarios.Clases.Mapeador.Extensiones;
using System;
using System.Linq;

namespace Infotrack.Base.Datos.Clases.DAL
{
    internal class CursoDAL : AccesoComunDAL<DatosContexto>, ICursoAction
    {
        private Respuesta<ICursoDTO> Respuesta;
        private RepositorioGenerico<Curso> Repositorio;

        public CursoDAL()
        {
            Respuesta = new Respuesta<ICursoDTO>();
            Repositorio = new RepositorioGenerico<Curso>(ContextoBD);
        }

        public Respuesta<ICursoDTO> ActualizarCurso(ICursoDTO cursoDTO)
        {
            return EjecutarTransaccion<Respuesta<ICursoDTO>, CursoDAL>(() =>
            {
                Curso curso= (Repositorio.BuscarPor(entidad => entidad.Id_Curso == cursoDTO.Id_Curso).FirstOrDefault());
                Repositorio.Editar(curso);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.ActualizacionExitosa);
                return Respuesta;
            });
        }

        public Respuesta<ICursoDTO> AgregarCurso(ICursoDTO cursoDTO)
        {
            return EjecutarTransaccion<Respuesta<ICursoDTO>, CursoDAL>(() =>
            {
                Curso curso = Mapeador.MapearEntidadDTO(cursoDTO, new Curso());
                //Curso curso = new Curso
                //{
                //    Id_Curso = cursoDTO.Id_Curso,
                //    Nombre = cursoDTO.Nombre,
                //    Estado = cursoDTO.Estado
                //};
                Repositorio.Agregar(curso);
                Repositorio.Guardar();
                return Respuesta;
            });
        }

        public Respuesta<ICursoDTO> ConsultarCursoId(int id)
        {
            return EjecutarTransaccion<Respuesta<ICursoDTO>, CursoDAL>(() =>
            {

                Respuesta.Entidades = Repositorio.BuscarPor(entidad => entidad.Id_Curso == id).ToList<ICursoDTO>();
                return Respuesta;
            });
        }

        public Respuesta<ICursoDTO> ConsultarCursos()
        {
            return EjecutarTransaccion<Respuesta<ICursoDTO>, CursoDAL>(() =>
            {
                Respuesta.Entidades = Repositorio.BuscarTodos().ToList<ICursoDTO>();
                return Respuesta;

            });
        }

        public Respuesta<ICursoDTO> EliminarCurso(ICursoDTO cursoDTO)
        {
            return EjecutarTransaccion<Respuesta<ICursoDTO>, CursoDAL>(() => {
                Curso curso = (Repositorio.BuscarPor(entidad => entidad.Id_Curso == cursoDTO.Id_Curso).FirstOrDefault());
                Repositorio.Eliminar(curso);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }
    }
}