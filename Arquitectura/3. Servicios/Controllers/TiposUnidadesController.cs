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
using Datos;
using Datos.Contexto.Entidades;

namespace WebApi.Controllers
{
    public class TiposUnidadesController : ApiController
    {
        private DatosContexto db = new DatosContexto();

        // GET: api/TiposUnidades
        public IQueryable<TiposUnidades> GetTiposUnidades()
        {
            return db.TiposUnidades;
        }

        // GET: api/TiposUnidades/5
        [ResponseType(typeof(TiposUnidades))]
        public async Task<IHttpActionResult> GetTiposUnidades(int id)
        {
            TiposUnidades tiposUnidades = await db.TiposUnidades.FindAsync(id);
            if (tiposUnidades == null)
            {
                return NotFound();
            }

            return Ok(tiposUnidades);
        }

        // PUT: api/TiposUnidades/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTiposUnidades(int id, TiposUnidades tiposUnidades)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tiposUnidades.TipoUnidadId)
            {
                return BadRequest();
            }

            db.Entry(tiposUnidades).State = System.Data.Entity.EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposUnidadesExists(id))
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

        // POST: api/TiposUnidades
        [ResponseType(typeof(TiposUnidades))]
        public async Task<IHttpActionResult> PostTiposUnidades(TiposUnidades tiposUnidades)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TiposUnidades.Add(tiposUnidades);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tiposUnidades.TipoUnidadId }, tiposUnidades);
        }

        // DELETE: api/TiposUnidades/5
        [ResponseType(typeof(TiposUnidades))]
        public async Task<IHttpActionResult> DeleteTiposUnidades(int id)
        {
            TiposUnidades tiposUnidades = await db.TiposUnidades.FindAsync(id);
            if (tiposUnidades == null)
            {
                return NotFound();
            }

            db.TiposUnidades.Remove(tiposUnidades);
            await db.SaveChangesAsync();

            return Ok(tiposUnidades);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TiposUnidadesExists(int id)
        {
            return db.TiposUnidades.Count(e => e.TipoUnidadId == id) > 0;
        }
    }
}