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
    class CursoDAL : AccesoComunDAL<DatosContexto>, ICursoAction
    {
        Respuesta<ICursoDTO> Respuesta;
        RepositorioGenerico<Curso> Repositorio;

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
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }

        public Respuesta<ICursoDTO> AgregarCurso(ICursoDTO cursoDTO)
        {
            return EjecutarTransaccion<Respuesta<ICursoDTO>, CursoDAL>(() =>
            {
                Curso curso = new Curso
                {
                    Id_Curso = cursoDTO.Id_Curso,
                    Nombre = cursoDTO.Nombre,
                    Estado = cursoDTO.Estado
                };
                Repositorio.Agregar(curso);
                Repositorio.Guardar();
                return Respuesta;
            });
        }

        public Respuesta<ICursoDTO> ConsultarCursoId(int id)
        {
            throw new NotImplementedException();
        }

        public Respuesta<ICursoDTO> ConsultarCursos()
        {
            throw new NotImplementedException();
        }

        public Respuesta<ICursoDTO> EliminarCurso(ICursoDTO cursoDTO)
        {
            throw new NotImplementedException();
        }
    }
}
