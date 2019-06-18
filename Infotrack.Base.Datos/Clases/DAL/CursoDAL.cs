﻿using Infotrack.Base.IC.Acciones.Entidades;
using Infotrack.Base.IC.DTO.EntidadesRepositorio;
using Infotrack.Transaccional.EF.Clases;
using Infotrack.Utilitarios.Clases.Comunes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotrack.Base.Datos.Clases.DAL
{
    class CursoDAL : AccesoComunDAL<DatosContexto>, ICursoAction
    {
        Respuesta<ICursoDTO> Respuesta;
        RepositorioGenerico<Curso> Repositorio;

        public CursoDAL()
        {
            Respuesta = new Respuesta<ICursoDTO>();
            Repositorio = new RepositorioGenerico<Curso>(ContextoBD);
        }
        public Respuesta<ICursoDTO> ActualizarCurso(ICursoDTO cursoDTO)
        {
            throw new NotImplementedException();
        }

        public Respuesta<ICursoDTO> AgregarCurso(ICursoDTO cursoDTO)
        {
            throw new NotImplementedException();
        }

        public Respuesta<ICursoDTO> ConsultarCursoId(int id)
        {
            throw new NotImplementedException();
        }

        public Respuesta<ICursoDTO> ConsultarCursos()
        {
            throw new NotImplementedException();
        }

        public Respuesta<ICursoDTO> EliminarCurso(ICursoDTO cursoDTO)
        {
            throw new NotImplementedException();
        }
    }
}
