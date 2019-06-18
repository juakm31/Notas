﻿using System;
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
    public class AlumnoesController : ApiController
    {
        private DatosContexto db = new DatosContexto();

        // GET: api/Alumnoes
        public IQueryable<Alumno> GetAlumno()
        {
            return db.Alumno;
        }

        // GET: api/Alumnoes/5
        [ResponseType(typeof(Alumno))]
        public async Task<IHttpActionResult> GetAlumno(int id)
        {
            Alumno alumno = await db.Alumno.FindAsync(id);
            if (alumno == null)
            {
                return NotFound();
            }

            return Ok(alumno);
        }

        // PUT: api/Alumnoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAlumno(int id, Alumno alumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != alumno.Id_Alumno)
            {
                return BadRequest();
            }

            db.Entry(alumno).State = System.Data.Entity.EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnoExists(id))
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

        // POST: api/Alumnoes
        [ResponseType(typeof(Alumno))]
        public async Task<IHttpActionResult> PostAlumno(Alumno alumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Alumno.Add(alumno);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = alumno.Id_Alumno }, alumno);
        }

        // DELETE: api/Alumnoes/5
        [ResponseType(typeof(Alumno))]
        public async Task<IHttpActionResult> DeleteAlumno(int id)
        {
            Alumno alumno = await db.Alumno.FindAsync(id);
            if (alumno == null)
            {
                return NotFound();
            }

            db.Alumno.Remove(alumno);
            await db.SaveChangesAsync();

            return Ok(alumno);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AlumnoExists(int id)
        {
            return db.Alumno.Count(e => e.Id_Alumno == id) > 0;
        }
    }
}