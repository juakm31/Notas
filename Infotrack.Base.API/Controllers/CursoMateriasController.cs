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
using Infotrack.Base.Datos;

namespace Infotrack.Base.API.Controllers
{
    public class CursoMateriasController : ApiController
    {
        private DatosContexto db = new DatosContexto();

        // GET: api/CursoMaterias
        public IQueryable<CursoMateria> GetCursoMateria()
        {
            return db.CursoMateria;
        }

        // GET: api/CursoMaterias/5
        [ResponseType(typeof(CursoMateria))]
        public async Task<IHttpActionResult> GetCursoMateria(int id)
        {
            CursoMateria cursoMateria = await db.CursoMateria.FindAsync(id);
            if (cursoMateria == null)
            {
                return NotFound();
            }

            return Ok(cursoMateria);
        }

        // PUT: api/CursoMaterias/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCursoMateria(int id, CursoMateria cursoMateria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cursoMateria.Id_CursoMateria)
            {
                return BadRequest();
            }

            db.Entry(cursoMateria).State = System.Data.Entity.EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoMateriaExists(id))
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

        // POST: api/CursoMaterias
        [ResponseType(typeof(CursoMateria))]
        public async Task<IHttpActionResult> PostCursoMateria(CursoMateria cursoMateria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CursoMateria.Add(cursoMateria);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cursoMateria.Id_CursoMateria }, cursoMateria);
        }

        // DELETE: api/CursoMaterias/5
        [ResponseType(typeof(CursoMateria))]
        public async Task<IHttpActionResult> DeleteCursoMateria(int id)
        {
            CursoMateria cursoMateria = await db.CursoMateria.FindAsync(id);
            if (cursoMateria == null)
            {
                return NotFound();
            }

            db.CursoMateria.Remove(cursoMateria);
            await db.SaveChangesAsync();

            return Ok(cursoMateria);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CursoMateriaExists(int id)
        {
            return db.CursoMateria.Count(e => e.Id_CursoMateria == id) > 0;
        }
    }
}