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
using Datos.Clases.DAL;
using Datos.Contexto.Entidades;

namespace WebApi.Controllers
{
    public class PaisController : ApiController
    {
        private DatosContexto db = new DatosContexto();

        // GET: api/Pais
        public IQueryable<Pais> GetPais()
        {
            PaisDAL pais = new PaisDAL();
            var aux = pais.ConsultarPais();
            return db.Pais;
        }

        // GET: api/Pais/5
        [ResponseType(typeof(Pais))]
        public async Task<IHttpActionResult> GetPais(int id)
        {
            Pais pais = await db.Pais.FindAsync(id);
            if (pais == null)
            {
                return NotFound();
            }

            return Ok(pais);
        }

        // PUT: api/Pais/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPais(int id, Pais pais)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pais.IdPais)
            {
                return BadRequest();
            }

            db.Entry(pais).State = System.Data.Entity.EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaisExists(id))
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

        // POST: api/Pais
        [ResponseType(typeof(Pais))]
        public async Task<IHttpActionResult> PostPais(Pais pais)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pais.Add(pais);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = pais.IdPais }, pais);
        }

        // DELETE: api/Pais/5
        [ResponseType(typeof(Pais))]
        public async Task<IHttpActionResult> DeletePais(int id)
        {
            Pais pais = await db.Pais.FindAsync(id);
            if (pais == null)
            {
                return NotFound();
            }

            db.Pais.Remove(pais);
            await db.SaveChangesAsync();

            return Ok(pais);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PaisExists(int id)
        {
            return db.Pais.Count(e => e.IdPais == id) > 0;
        }
    }
}