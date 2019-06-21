using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infotrack.Base.API.Models
{
    public class Nota : INotaDTO
    {
        public int Id_Nota { get ; set ; }
        public int Id_Curso { get ; set ; }
        public int Id_Materia { get ; set ; }
        public int Id_Alumno { get ; set ; }
        public double Nota1 { get ; set ; }
    }
}