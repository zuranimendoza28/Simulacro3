using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Proyectos;

namespace Simulacro3.Controllers.Proyectos
{
    public class ProyectoController : ControllerBase
    {
        private readonly IProyectosRepository _ProyectosRepository;
        public ProyectoController(IProyectosRepository ProyectosRepository)
        {
            _ProyectosRepository = ProyectosRepository;
        }
        [HttpGet, Route("api/Proyectos")]
        public async Task<IEnumerable<Proyecto>> GetAll()
        {
            return await _ProyectosRepository.GetAll();
        }
        [HttpGet, Route("api/Proyectos/{Id}")]
        public async Task<Proyecto> Get(int Id)
        {
        return await _ProyectosRepository.GetById(Id);
        }
    }
}