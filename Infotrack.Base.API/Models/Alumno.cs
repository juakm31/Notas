using Infotrack.Base.IC.DTO.EntidadesRepositorio;

namespace Infotrack.Base.API.Models
{
    public class Alumno : IAlumnoDTO
    {
        public Alumno()
        {

        }

        public int Id_Alumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
    }
}