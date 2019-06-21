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
using Infotrack.Base.Datos.Clases.DAL;
using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.Negocio.Clases.BL;
using Infotrack.Utilitarios.API.Clases.Ejecucion;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using Infotrack.Utilitarios.Clases.Mapeador.Extensiones;

namespace Infotrack.Base.API.Controllers
{
    [RoutePrefix("api/Curso")]
    public class CursoeController : AccesoComunAPI
    {
        private Lazy<CursoBL> NegocioCurso;
        public CursoeController()
        {
            NegocioCurso = new Lazy<CursoBL>(() => new CursoBL(new Lazy<ICursoAction>(() => new CursoDAL())));
        }

        [HttpGet]
        [Route("ConsultarListaCursos")]
        // GET: api/Cursoe
        public Respuesta<Models.Curso> GetCurso()
        {
            return Mapeador.MapearObjetoPorJson<Respuesta<Models.Curso>>(NegocioCurso.Value.ConsultarCursos());
        }

        [HttpGet]
        [Route("ConsultarLMateriasCurso")]
        public Respuesta<Models.CursoMateria> GetMateriasCurso()
        {
            return Mapeador.MapearObjetoPorJson<Respuesta<Models.CursoMateria>>(NegocioCurso.Value.ObtenerMateriasPorCurso());
        }

        [HttpGet]
        [Route("ConsultarMateriaPorIdCurso")]
        public Respuesta<Models.CursoMateria> GetMateriaPorIdCurso(int id)
        {
            return Mapeador.MapearObjetoPorJson<Respuesta<Models.CursoMateria>>(NegocioCurso.Value.ObtenerMateriasPorIdCurso(id));
        }

        [HttpGet]
        [Route("ConsultarAlumnosCurso")]
        public Respuesta<Models.CursoAlumno> GetAlumnosCurso()
        {
            return Mapeador.MapearObjetoPorJson<Respuesta<Models.CursoAlumno>>(NegocioCurso.Value.ObtenerAlumnosPorCurso());
        }

        [HttpGet]
        [Route("ConsultarAlumnosPorIdCurso")]
        public Respuesta<Models.CursoAlumno> GetAlumnoPorIdCurso(int id)
        {
            return Mapeador.MapearObjetoPorJson<Respuesta<Models.CursoAlumno>>(NegocioCurso.Value.ObtenerAlumnosPorIdCurso(id));
        }

        //// GET: api/Cursoe/5
        //[ResponseType(typeof(Curso))]
        //public async Task<IHttpActionResult> GetCurso(int id)
        //{
        //    Curso curso = await db.Curso.FindAsync(id);
        //    if (curso == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(curso);
        //}

        //// PUT: api/Cursoe/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutCurso(int id, Curso curso)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != curso.Id_Curso)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(curso).State = System.Data.Entity.EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CursoExists(id))
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

        //// POST: api/Cursoe
        //[ResponseType(typeof(Curso))]
        //public async Task<IHttpActionResult> PostCurso(Curso curso)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Curso.Add(curso);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = curso.Id_Curso }, curso);
        //}

        //// DELETE: api/Cursoe/5
        //[ResponseType(typeof(Curso))]
        //public async Task<IHttpActionResult> DeleteCurso(int id)
        //{
        //    Curso curso = await db.Curso.FindAsync(id);
        //    if (curso == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Curso.Remove(curso);
        //    await db.SaveChangesAsync();

        //    return Ok(curso);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool CursoExists(int id)
        //{
        //    return db.Curso.Count(e => e.Id_Curso == id) > 0;
        //}
    }
}