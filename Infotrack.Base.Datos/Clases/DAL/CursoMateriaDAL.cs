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
    public class CursoMateriaDAL : AccesoComunDAL<DatosContexto>, ICursoMateriaAcciones
    {
        Respuesta<ICursoMateriaDTO> Respuesta;
        RepositorioGenerico<CursoMateria> RepositorioCursoMateria;

        public CursoMateriaDAL()
        {
            Respuesta = new Respuesta<ICursoMateriaDTO>();
            RepositorioCursoMateria = new RepositorioGenerico<CursoMateria>(ContextoBD);
        }

        public Respuesta<ICursoMateriaDTO> ActualizarCursoMateria(ICursoMateriaDTO cursoMateriaDTO)
        {
            return EjecutarTransaccion<Respuesta<ICursoMateriaDTO>, CursoMateriaDAL>(() =>
            {
                CursoMateria cursoMateria = (RepositorioCursoMateria.BuscarPor(entidad => entidad.Id_CursoMateria == cursoMateriaDTO.Id_CursoMateria).FirstOrDefault());
                RepositorioCursoMateria.Editar(cursoMateria);
                RepositorioCursoMateria.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.ActualizacionExitosa);

                return Respuesta;
            });
        }

        public Respuesta<ICursoMateriaDTO> AgregarCursoMateria(ICursoMateriaDTO cursoMateriaDTO)
        {
            return EjecutarTransaccion<Respuesta<ICursoMateriaDTO>, CursoMateriaDAL>(() =>
            {
                CursoMateria cursoMateria = Mapeador.MapearEntidadDTO(cursoMateriaDTO, new CursoMateria());
                RepositorioCursoMateria.Agregar(cursoMateria);
                RepositorioCursoMateria.Guardar();
                Respuesta.Resultado = true;
                Respuesta.Mensajes.Add(MensajesComunes.MensajeCreacionExitosa);
                Respuesta.Entidades.Add(cursoMateria);
                //Respuesta.TipoNotificacion = "";

                return Respuesta;
            });
        }

        public Respuesta<ICursoMateriaDTO> ConsultarCursoMateria()
        {
            return EjecutarTransaccion<Respuesta<ICursoMateriaDTO>, CursoAlumnoDAL>(() =>
            {
                Respuesta.Entidades = RepositorioCursoMateria.BuscarTodos().ToList<ICursoMateriaDTO>();
                return Respuesta;

            });
        }

        public Respuesta<ICursoMateriaDTO> ConsultarCursoMateriaPorID(int idCursoMateria)
        {
            return EjecutarTransaccion<Respuesta<ICursoMateriaDTO>, CursoAlumnoDAL>(() =>
            {

                Respuesta.Entidades = RepositorioCursoMateria.BuscarPor(entidad => entidad.Id_CursoMateria == idCursoMateria).ToList<ICursoMateriaDTO>();
                return Respuesta;
            });
        }

        public Respuesta<ICursoMateriaDTO> EliminarCursoMateriaPorID(int idCursoMateria)
        {
            return EjecutarTransaccion<Respuesta<ICursoMateriaDTO>, CursoAlumnoDAL>(() => {
                CursoMateria cursoMateria = (RepositorioCursoMateria.BuscarPor(entidad => entidad.Id_CursoMateria == idCursoMateria).FirstOrDefault());
                RepositorioCursoMateria.Eliminar(cursoMateria);
                RepositorioCursoMateria.Guardar();
                Respuesta.Mensajes.Add(MensajesComunes.EliminacionExitosa);
                return Respuesta;
            });
        }
    }
}
