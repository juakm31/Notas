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
    public class CursoeController : ApiController
    {
        private DatosContexto db = new DatosContexto();

        // GET: api/Cursoe
        public IQueryable<Curso> GetCurso()
        {
            return db.Curso;
        }

        // GET: api/Cursoe/5
        [ResponseType(typeof(Curso))]
        public async Task<IHttpActionResult> GetCurso(int id)
        {
            Curso curso = await db.Curso.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }

            return Ok(curso);
        }

        // PUT: api/Cursoe/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCurso(int id, Curso curso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != curso.Id_Curso)
            {
                return BadRequest();
            }

            db.Entry(curso).State = System.Data.Entity.EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoExists(id))
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

        // POST: api/Cursoe
        [ResponseType(typeof(Curso))]
        public async Task<IHttpActionResult> PostCurso(Curso curso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Curso.Add(curso);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = curso.Id_Curso }, curso);
        }

        // DELETE: api/Cursoe/5
        [ResponseType(typeof(Curso))]
        public async Task<IHttpActionResult> DeleteCurso(int id)
        {
            Curso curso = await db.Curso.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }

            db.Curso.Remove(curso);
            await db.SaveChangesAsync();

            return Ok(curso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CursoExists(int id)
        {
            return db.Curso.Count(e => e.Id_Curso == id) > 0;
        }
    }
}