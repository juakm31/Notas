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
    public class CursoAlumnoesController : ApiController
    {
        private DatosContexto db = new DatosContexto();

        // GET: api/CursoAlumnoes
        public IQueryable<CursoAlumno> GetCursoAlumno()
        {
            return db.CursoAlumno;
        }

        // GET: api/CursoAlumnoes/5
        [ResponseType(typeof(CursoAlumno))]
        public async Task<IHttpActionResult> GetCursoAlumno(int id)
        {
            CursoAlumno cursoAlumno = await db.CursoAlumno.FindAsync(id);
            if (cursoAlumno == null)
            {
                return NotFound();
            }

            return Ok(cursoAlumno);
        }

        // PUT: api/CursoAlumnoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCursoAlumno(int id, CursoAlumno cursoAlumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cursoAlumno.Id_CursoAlumno)
            {
                return BadRequest();
            }

            db.Entry(cursoAlumno).State = System.Data.Entity.EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoAlumnoExists(id))
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

        // POST: api/CursoAlumnoes
        [ResponseType(typeof(CursoAlumno))]
        public async Task<IHttpActionResult> PostCursoAlumno(CursoAlumno cursoAlumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CursoAlumno.Add(cursoAlumno);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cursoAlumno.Id_CursoAlumno }, cursoAlumno);
        }

        // DELETE: api/CursoAlumnoes/5
        [ResponseType(typeof(CursoAlumno))]
        public async Task<IHttpActionResult> DeleteCursoAlumno(int id)
        {
            CursoAlumno cursoAlumno = await db.CursoAlumno.FindAsync(id);
            if (cursoAlumno == null)
            {
                return NotFound();
            }

            db.CursoAlumno.Remove(cursoAlumno);
            await db.SaveChangesAsync();

            return Ok(cursoAlumno);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CursoAlumnoExists(int id)
        {
            return db.CursoAlumno.Count(e => e.Id_CursoAlumno == id) > 0;
        }
    }
}