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

namespace Infotrack.Base.Datos.Clases.DAL
{
    public class CursoDAL : AccesoComunDAL<DatosContexto>, ICursoAction
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

        public Respuesta<IMateriaPorCursoDTO> ObtenerMateriasPorCurso()
        {
            return EjecutarTransaccion<Respuesta<IMateriaPorCursoDTO>, CursoDAL>(() =>
            {
                Respuesta<IMateriaPorCursoDTO> respuestaMateriasCurso = new Respuesta<IMateriaPorCursoDTO>();

                respuestaMateriasCurso.Entidades = (from cm in ContextoBD.CursoMateria
                                                           join c in ContextoBD.Curso on cm.Id_Curso equals c.Id_Curso
                                                           join m in ContextoBD.Materia on cm.Id_Materia equals m.Id_Materia
                                                            group m.Nombre by c.Nombre into g
                                                            select new MateriasPorCursoDO
                                                           {
                                                               NombreCurso = g.Key,
                                                               ListaMaterias = g.ToList()
                                                           }).ToList<IMateriaPorCursoDTO>();

                return respuestaMateriasCurso;
            });
        }

        public Respuesta<IMateriaPorCursoDTO> ObtenerMateriasPorIdCurso(int id)
        {
            return EjecutarTransaccion<Respuesta<IMateriaPorCursoDTO>, CursoDAL>(() =>
            {
                Respuesta<IMateriaPorCursoDTO> respuestaMateriasCurso = new Respuesta<IMateriaPorCursoDTO>();

                respuestaMateriasCurso.Entidades = (from cm in ContextoBD.CursoMateria
                           join c in ContextoBD.Curso on cm.Id_Curso equals c.Id_Curso
                           join m in ContextoBD.Materia on cm.Id_Materia equals m.Id_Materia
                           where c.Id_Curso == id
                           group m.Nombre by c.Nombre into g
                           select new MateriasPorCursoDO
                           {
                               NombreCurso = g.Key,
                               ListaMaterias = g.ToList()
                           }).ToList<IMateriaPorCursoDTO>();
                return respuestaMateriasCurso;
            });
        }

        public Respuesta<IAlumnoPorCursoDTO> ObtenerAlumnosPorCurso()
        {
            return EjecutarTransaccion<Respuesta<IAlumnoPorCursoDTO>, CursoDAL>(() =>
            {
                Respuesta<IAlumnoPorCursoDTO> respuestaAlumnoMateria = new Respuesta<IAlumnoPorCursoDTO>();

                respuestaAlumnoMateria.Entidades = (from ca in ContextoBD.CursoAlumno
                                                    join a in ContextoBD.Alumno on ca.Id_Alumno equals a.Id_Alumno
                                                    join c in ContextoBD.Curso on ca.Id_Curso equals c.Id_Curso
                                                    group a.Nombre by c.Nombre into g
                                                    select new AlumnosPorCurso
                                                    {
                                                        NombreCurso = g.Key,
                                                        ListAlumnos = g.ToList()
                                                    }).ToList<IAlumnoPorCursoDTO>();

                return respuestaAlumnoMateria;
            });
        }

        public Respuesta<IAlumnoPorCursoDTO> ObtenerAlumnosPorIdCurso(int id)
        {
            Respuesta<IAlumnoPorCursoDTO> respuestaAlumnoMateria = new Respuesta<IAlumnoPorCursoDTO>();

            respuestaAlumnoMateria.Entidades = (from ca in ContextoBD.CursoAlumno
                                                join a in ContextoBD.Alumno on ca.Id_Alumno equals a.Id_Alumno
                                                join c in ContextoBD.Curso on ca.Id_Curso equals c.Id_Curso
                                                where c.Id_Curso == id
                                                group a.Nombre by c.Nombre into g
                                                select new AlumnosPorCurso
                                                {
                                                    NombreCurso = g.Key,
                                                    ListAlumnos = g.ToList()
                                                }).ToList<IAlumnoPorCursoDTO>();

            return respuestaAlumnoMateria;
        }
    }
}