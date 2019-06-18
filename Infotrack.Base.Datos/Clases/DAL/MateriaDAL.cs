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
    internal class MateriaDAL : AccesoComunDAL<DatosContexto>, IMateriaAction
    {
        private Respuesta<IMateriaDTO> Respuesta;
        private RepositorioGenerico<Materia> Repositorio;

        public MateriaDAL()
        {
            Respuesta = new Respuesta<IMateriaDTO>();
            Repositorio = new RepositorioGenerico<Materia>(ContextoBD);
        }

        public Respuesta<IMateriaDTO> ActualizarMateria(IMateriaDTO materiaDTO)
        {
            return EjecutarTransaccion<Respuesta<IMateriaDTO>, MateriaDAL>(() =>
            {
                Materia materia = (Repositorio.BuscarPor(entidad => entidad.Id_Materia == materiaDTO.Id_Materia).FirstOrDefault());
                Repositorio.Editar(materia);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.ActualizacionExitosa);

                return Respuesta;
            });
        }

        public Respuesta<IMateriaDTO> AgregarMateria(IMateriaDTO materiaDTO)
        {
            return EjecutarTransaccion<Respuesta<IMateriaDTO>, MateriaDAL>(() =>
            {
                Materia materia = Mapeador.MapearEntidadDTO(materiaDTO, new Materia());
                //Materia materia = new Materia
                //{
                //    Id_Materia = materiaDTO.Id_Materia,
                //    Estado = materiaDTO.Estado,
                //    Nombre = materiaDTO.Nombre
                //};
                Repositorio.Agregar(materia);
                Repositorio.Guardar();
                return Respuesta;
            });
        }

        public Respuesta<IMateriaDTO> ConsultarMateriaId(int id)
        {
            return EjecutarTransaccion<Respuesta<IMateriaDTO>, MateriaDAL>(() =>
            {

                Respuesta.Entidades = Repositorio.BuscarPor(entidad => entidad.Id_Materia == id).ToList<IMateriaDTO>();
                return Respuesta;
            });
        }

        public Respuesta<IMateriaDTO> ConsultarMaterias()
        {
            return EjecutarTransaccion<Respuesta<IMateriaDTO>, MateriaDAL>(() =>
            {
                Respuesta.Entidades = Repositorio.BuscarTodos().ToList<IMateriaDTO>();
                return Respuesta;

            });
        }

        public Respuesta<IMateriaDTO> EliminarMateria(IMateriaDTO materiaDTO)
        {
            return EjecutarTransaccion<Respuesta<IMateriaDTO>, MateriaDAL>(() => {
                Materia materia = (Repositorio.BuscarPor(entidad => entidad.Id_Materia == materiaDTO.Id_Materia).FirstOrDefault());
                Repositorio.Eliminar(materia);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }
    }
}