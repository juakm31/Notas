using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Infotrack.Base.API.Models;
using Infotrack.Base.Datos.Clases.DAL;
using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.Negocio.Clases.BL;
using Infotrack.Utilitarios.API.Clases.Ejecucion;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using Infotrack.Utilitarios.Clases.Mapeador.Extensiones;

namespace Infotrack.Base.API.Controllers
{
    [RoutePrefix("api/Notas")]
    public class NotasController : AccesoComunAPI
    {
        //private DatosContexto db = new DatosContexto();

        private Lazy<NotaBL> NegocioCurso;
        public NotasController()
        {
            NegocioCurso = new Lazy<NotaBL>(() => new NotaBL(new Lazy<INotaAcciones>(() => new NotasDAL())));
        }

        [HttpGet]
        [Route("ConsultarNotas")]
        // GET: api/Notas
        public Respuesta<Nota> GetNota()
        {
            return Mapeador.MapearObjetoPorJson<Respuesta<Nota>>(NegocioCurso.Value.ConsultarNotas());
        }

        [HttpPost]
        [Route("FiltroNota")]
        public Respuesta<FiltroNota> Filtro(Nota nota)
        {
            return Mapeador.MapearObjetoPorJson<Respuesta<FiltroNota>>(NegocioCurso.Value.FiltroNota(nota));
        }

        /* GET: api/Notas/5
        //[ResponseType(typeof(Nota))]
        public Respuesta<Nota> Filtro(Nota nota)
        {
            return Mape
        }
        /*
        // PUT: api/Notas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutNota(int id, Nota nota)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nota.Id_Nota)
            {
                return BadRequest();
            }

            db.Entry(nota).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Notas
        [ResponseType(typeof(Nota))]
        public async Task<IHttpActionResult> PostNota(Nota nota)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Nota.Add(nota);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = nota.Id_Nota }, nota);
        }

        // DELETE: api/Notas/5
        [ResponseType(typeof(Nota))]
        public async Task<IHttpActionResult> DeleteNota(int id)
        {
            Nota nota = await db.Nota.FindAsync(id);
            if (nota == null)
            {
                return NotFound();
            }

            db.Nota.Remove(nota);
            await db.SaveChangesAsync();

            return Ok(nota);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NotaExists(int id)
        {
            return db.Nota.Count(e => e.Id_Nota == id) > 0;
        }*/
    }
}