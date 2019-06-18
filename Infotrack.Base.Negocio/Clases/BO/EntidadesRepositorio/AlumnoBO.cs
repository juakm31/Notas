using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Negocio.Clases.BO.EntidadesRepositorio
{
    public class AlumnoBO : IAlumnoDTO
    {
        public int Id_Alumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
    }
}
