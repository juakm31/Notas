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
    public class FamiliasDAL : AccesoComunDAL<DatosContexto>, IFamiliasAcciones
    {
        Respuesta<IFamiliasDTO> Respuesta;
        RepositorioGenerico<Familias> Repositorio;

        public FamiliasDAL()
        {
            Respuesta = new Respuesta<IFamiliasDTO>();
            Repositorio = new RepositorioGenerico<Familias>(ContextoBD);
        }
        public Respuesta<IFamiliasDTO> ActualizarFamilias(IFamiliasDTO familiasDTO)
        {
            return EjecutarTransaccion<Respuesta<IFamiliasDTO>, FamiliasDAL>(() =>
            {
                Familias familias = (Repositorio.BuscarPor(entidad => entidad.FamiliaId == familiasDTO.FamiliaId).FirstOrDefault());
                Repositorio.Editar(familias);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }

        public Respuesta<IFamiliasDTO> AgregarFamilia(IFamiliasDTO familiasDTO)
        {
            return EjecutarTransaccion<Respuesta<IFamiliasDTO>, FamiliasDAL>(() =>
            {
                Familias familias = new Familias
                {
                    FamiliaId = familiasDTO.FamiliaId,
                    FamiliaDescripcion = familiasDTO.FamiliaDescripcion,
                    EmpresaId = familiasDTO.EmpresaId
                };
                Repositorio.Agregar(familias);
                Repositorio.Guardar();
                return Respuesta;
            });
        }

        public Respuesta<IFamiliasDTO> ConsultarFamiliaId(int id)
        {
            return EjecutarTransaccion<Respuesta<IFamiliasDTO>, FamiliasDAL>(() =>
            {

                Respuesta.Entidades = Repositorio.BuscarPor(entidad => entidad.FamiliaId == id).ToList<IFamiliasDTO>();
                return Respuesta;
            });
        }

        public Respuesta<IFamiliasDTO> ConsultarFamilias()
        {
            return EjecutarTransaccion<Respuesta<IFamiliasDTO>, FamiliasDAL>(() =>
            {
                Respuesta.Entidades = Repositorio.BuscarTodos().ToList<IFamiliasDTO>();
                return Respuesta;

            });
        }

        public Respuesta<IFamiliasDTO> EliminarFamilia(IFamiliasDTO familiasDTO)
        {
            return EjecutarTransaccion<Respuesta< IFamiliasDTO >, FamiliasDAL > (() => {
                Familias familias = (Repositorio.BuscarPor(entidad => entidad.FamiliaId == familiasDTO.FamiliaId).FirstOrDefault());
                Repositorio.Eliminar(familias);
                Repositorio.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }
    }
}
