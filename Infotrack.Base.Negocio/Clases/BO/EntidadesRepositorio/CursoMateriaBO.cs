using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Negocio.Clases.BO.EntidadesRepositorio
{
    public class CursoMateriaBO : ICursoMateriaDTO
    {
        public int Id_CursoMateria { get; set; }
        public int Id_Materia { get; set; }
        public int Id_Curso { get; set; }
    }
}
