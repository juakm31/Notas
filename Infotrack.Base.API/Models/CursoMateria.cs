using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infotrack.Base.API.Models
{
    public class CursoMateria : IMateriaPorCursoDTO
    {
        public string NombreCurso { get; set; }
        public List<string> ListaMaterias { get; set; }
    }
}