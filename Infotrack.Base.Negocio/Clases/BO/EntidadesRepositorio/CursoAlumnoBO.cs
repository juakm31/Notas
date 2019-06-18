using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Negocio.Clases.BO.EntidadesRepositorio
{
    public class CursoAlumnoBO : ICursoAlumnoDTO
    {
        public int Id_CursoAlumno { get; set; }
        public int Id_Alumno { get; set; }
        public int Id_Curso { get; set; }
    }
}
