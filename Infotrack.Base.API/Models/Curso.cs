using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infotrack.Base.API.Models
{
    public class Curso : ICursoDTO
    {
        public Curso()
        {

        }
        public int Id_Curso { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
    }
}