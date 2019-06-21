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
using Infotrack.Base.Datos;
using Infotrack.Base.Datos.Clases.DAL;
using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Base.Negocio.Clases.BL;
using Infotrack.Utilitarios.API.Clases.Ejecucion;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using Infotrack.Utilitarios.Clases.Mapeador.Extensiones;

namespace Infotrack.Base.API.Controllers
{
    [RoutePrefix("api/Alumno")]
    public class AlumnoesController : AccesoComunAPI
    {
        private Lazy<AlumnoBL> NegocioAlumno;
        public AlumnoesController()
        {
            NegocioAlumno = new Lazy<AlumnoBL>(() => new AlumnoBL(new Lazy<IAlumnoAction>(() => new AlumnoDAL())));
        }

        [HttpGet]
        [Route("ConsultarListaAlumnos")]
        // GET: api/Alumnoes
        public Respuesta<Models.Alumno> GetAlumno()
        {
            return Mapeador.MapearObjetoPorJson<Respuesta<Models.Alumno>>(NegocioAlumno.Value.ConsultarAlumnos());
        }

        [HttpGet]
        [Route("ConsultarListaAlumnosId")]
        // GET: api/Alumnoes/5
        // [ResponseType(typeof(Alumno))]
        public Respuesta<Datos.Alumno> GetAlumno(int id)
        {
            return Mapeador.MapearObjetoPorJson<Respuesta<Datos.Alumno>>(NegocioAlumno.Value.ConsultarAlumnoId(id));
        }

        //// PUT: api/Alumnoes/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutAlumno(int id, Alumno alumno)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != alumno.Id_Alumno)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(alumno).State = System.Data.Entity.EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AlumnoExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Alumnoes
        //[ResponseType(typeof(Alumno))]
        //public async Task<IHttpActionResult> PostAlumno(Alumno alumno)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Alumno.Add(alumno);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = alumno.Id_Alumno }, alumno);
        //}

        //// DELETE: api/Alumnoes/5
        //[ResponseType(typeof(Alumno))]
        //public async Task<IHttpActionResult> DeleteAlumno(int id)
        //{
        //    Alumno alumno = await db.Alumno.FindAsync(id);
        //    if (alumno == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Alumno.Remove(alumno);
        //    await db.SaveChangesAsync();

        //    return Ok(alumno);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool AlumnoExists(int id)
        //{
        //    return db.Alumno.Count(e => e.Id_Alumno == id) > 0;
        //}
    }
}