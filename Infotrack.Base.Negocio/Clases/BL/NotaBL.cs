using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.IC.DTO.Consultas;
using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Transaccional.EF.Clases;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Negocio.Clases.BL
{
    public class NotaBL : AccesoComunBL, INotaAcciones
    {
        private Lazy<INotaAcciones> RepositorioNota;
        private Respuesta<INotaAcciones> RespuestaNota;

        public NotaBL(Lazy<INotaAcciones> repositorioNota)
        {
            RepositorioNota = repositorioNota;
            RespuestaNota = new Respuesta<INotaAcciones>();
        }

        public Respuesta<INotaDTO> ActualizarNota(INotaDTO notaDTO)
        {
            return EjecutarTransaccionBD<Respuesta<INotaDTO>, NotaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioNota.Value.ActualizarNota(notaDTO);
            });
        }

        public Respuesta<INotaDTO> AgregarNota(INotaDTO notaDTO)
        {
            return EjecutarTransaccionBD<Respuesta<INotaDTO>, NotaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioNota.Value.AgregarNota(notaDTO);
            });
        }

        public Respuesta<INotaDTO> ConsultarNotaPorID(int idNota)
        {
            return EjecutarTransaccionBD<Respuesta<INotaDTO>, NotaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioNota.Value.ConsultarNotaPorID(idNota);
            });
        }

        public Respuesta<INotaDTO> ConsultarNotas()
        {
            return EjecutarTransaccionBD<Respuesta<INotaDTO>, NotaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioNota.Value.ConsultarNotas();
            });
        }

        public Respuesta<INotaDTO> EliminarNotaPorID(int idNota)
        {
            return EjecutarTransaccionBD<Respuesta<INotaDTO>, NotaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioNota.Value.EliminarNotaPorID(idNota);
            });
        }

        public Respuesta<IFiltroNotaDTO> FiltroNota(INotaDTO notaDTO)
        {
            return EjecutarTransaccionBD<Respuesta<IFiltroNotaDTO>, NotaBL>(System.Transactions.IsolationLevel.ReadUncommitted, () =>
            {
                return RepositorioNota.Value.FiltroNota(notaDTO);
            });
        }
    }
}
