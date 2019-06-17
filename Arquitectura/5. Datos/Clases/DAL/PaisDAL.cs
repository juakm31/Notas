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
    public class PaisDAL : AccesoComunDAL<DatosContexto>, IPaisAcciones
    {
        Respuesta<IPaisDTO> Respuesta;
        RepositorioGenerico<Pais> Repositorio;

        public PaisDAL()
        {
            Respuesta = new Respuesta<IPaisDTO>();
            Repositorio = new RepositorioGenerico<Pais>(ContextoBD);
        }
        public Respuesta<IPaisDTO> ActualizarPais(IPaisDTO paisDTO)
        {
            return EjecutarTransaccion<Respuesta<IPaisDTO>, PaisDAL>(() =>
            {
                Pais pais = (Repositorio.BuscarPor(entidad => entidad.IdPais == paisDTO.IdPais).FirstOrDefault());
                Repositorio.Editar(pais);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }
        public Respuesta<IPaisDTO> AgregarPais(IPaisDTO paisDTO)
        {
            return EjecutarTransaccion<Respuesta<IPaisDTO>, PaisDAL>(() =>
            {
                Pais pais = new Pais
                {
                    IdPais = paisDTO.IdPais,
                    CodigoPais = paisDTO.CodigoPais,
                    NombrePais = paisDTO.NombrePais,
                    EstadoPais = paisDTO.EstadoPais,
                    Version = paisDTO.Version
                };
                Repositorio.Agregar(pais);
                Repositorio.Guardar();
                return Respuesta;
            });
        }
        public Respuesta<IPaisDTO> ConsultarPais()
        {
            return EjecutarTransaccion<Respuesta<IPaisDTO>, PaisDAL>(() =>
            {
                Respuesta.Entidades = Repositorio.BuscarTodos().ToList<IPaisDTO>();
                return Respuesta;

            });
        }
        public Respuesta<IPaisDTO> ConsultarPaisId(int id)
        {
            return EjecutarTransaccion<Respuesta<IPaisDTO>, PaisDAL>(() =>
            {

                Respuesta.Entidades = Repositorio.BuscarPor(entidad => entidad.IdPais == id).ToList<IPaisDTO>();
                return Respuesta;
            });
        }
        public Respuesta<IPaisDTO> EliminarPais(IPaisDTO paisDTO)
        {
            return EjecutarTransaccion<Respuesta<IPaisDTO>, PaisDAL > (() => {
                Pais pais = (Repositorio.BuscarPor(entidad => entidad.IdPais == paisDTO.IdPais).FirstOrDefault());
                Repositorio.Eliminar(pais);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }
    }
}
