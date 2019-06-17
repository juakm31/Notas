using Datos.Contexto.Entidades;
using Infotrack.Transaccional.EF.Clases;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using InterfacesComunes.Acciones;
using InterfacesComunes.App_LocalResources;
using InterfacesComunes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Clases.DAL
{
    public class TiposUnidadesDAL : AccesoComunDAL<DatosContexto>, ITiposUnidadesAcciones
    {
        Respuesta<ITiposUnidadesDTO> Respuesta;
        RepositorioGenerico<TiposUnidades> Repositorio;

        public TiposUnidadesDAL()
        {
            Respuesta = new Respuesta<ITiposUnidadesDTO>();
            Repositorio = new RepositorioGenerico<TiposUnidades>(ContextoBD);
        }
        public Respuesta<ITiposUnidadesDTO> ActualizarTiposUnidades(ITiposUnidadesDTO tiposUnidadesDTO)
        {
            return EjecutarTransaccion<Respuesta<ITiposUnidadesDTO>, TiposUnidadesDAL>(() =>
            {
                TiposUnidades tiposUnidades = (Repositorio.BuscarPor(entidad => entidad.TipoUnidadId == tiposUnidadesDTO.TipoUnidadId).FirstOrDefault());
                Repositorio.Editar(tiposUnidades);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }

        public Respuesta<ITiposUnidadesDTO> AgregarTipoUnidades(ITiposUnidadesDTO tiposUnidadesDTO)
        {
            return EjecutarTransaccion<Respuesta<ITiposUnidadesDTO>, TiposUnidadesDAL>(() =>
            {
                TiposUnidades tiposUnidades = new TiposUnidades
                {
                    
                    TipoUnidadId= tiposUnidadesDTO.TipoUnidadId,
                    EmpresaId = tiposUnidadesDTO.EmpresaId,
                    DescripcionTipoUnidad = tiposUnidadesDTO.DescripcionTipoUnidad
                };
                Repositorio.Agregar(tiposUnidades);
                Repositorio.Guardar();
                return Respuesta;
            });
        }

        public Respuesta<ITiposUnidadesDTO> ConsultarTiposUnidades()
        {
            return EjecutarTransaccion<Respuesta<ITiposUnidadesDTO>, TiposUnidadesDAL>(() =>
            {
                Respuesta.Entidades = Repositorio.BuscarTodos().ToList<ITiposUnidadesDTO>();
                return Respuesta;

            });
        }

        public Respuesta<ITiposUnidadesDTO> ConsultarTipoUnidadesId(int id)
        {
            return EjecutarTransaccion<Respuesta<ITiposUnidadesDTO>, TiposUnidadesDAL>(() =>
            {

                Respuesta.Entidades = Repositorio.BuscarPor(entidad => entidad.TipoUnidadId == id).ToList<ITiposUnidadesDTO>();
                return Respuesta;
            });
        }

        public Respuesta<ITiposUnidadesDTO> EliminarTipoUnidad(ITiposUnidadesDTO tiposUnidadesDTO)
        {
            return EjecutarTransaccion<Respuesta<ITiposUnidadesDTO>, TiposUnidadesDAL>(() => {
                TiposUnidades tiposUnidades = (Repositorio.BuscarPor(entidad => entidad.TipoUnidadId == tiposUnidadesDTO.TipoUnidadId).FirstOrDefault());
                Repositorio.Eliminar(tiposUnidades);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }
    }
}
