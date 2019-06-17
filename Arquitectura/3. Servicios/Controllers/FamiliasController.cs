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
    public class FamiliasController : ApiController
    {
        private DatosContexto db = new DatosContexto();

        // GET: api/Familias
        public IQueryable<Familias> GetFamilias()
        {
            return db.Familias;
        }

        // GET: api/Familias/5
        [ResponseType(typeof(Familias))]
        public async Task<IHttpActionResult> GetFamilias(int id)
        {
            Familias familias = await db.Familias.FindAsync(id);
            if (familias == null)
            {
                return NotFound();
            }

            return Ok(familias);
        }

        // PUT: api/Familias/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFamilias(int id, Familias familias)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != familias.FamiliaId)
            {
                return BadRequest();
            }

            db.Entry(familias).State = System.Data.Entity.EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FamiliasExists(id))
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

        // POST: api/Familias
        [ResponseType(typeof(Familias))]
        public async Task<IHttpActionResult> PostFamilias(Familias familias)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Familias.Add(familias);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = familias.FamiliaId }, familias);
        }

        // DELETE: api/Familias/5
        [ResponseType(typeof(Familias))]
        public async Task<IHttpActionResult> DeleteFamilias(int id)
        {
            Familias familias = await db.Familias.FindAsync(id);
            if (familias == null)
            {
                return NotFound();
            }

            db.Familias.Remove(familias);
            await db.SaveChangesAsync();

            return Ok(familias);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FamiliasExists(int id)
        {
            return db.Familias.Count(e => e.FamiliaId == id) > 0;
        }
    }
}