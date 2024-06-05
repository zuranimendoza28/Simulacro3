using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Proyectos;

namespace Simulacro3.Controllers.Proyectos
{
    public class ProyectoCreateController : ControllerBase
    {
        private readonly IProyectosRepository _ProyectosRepository;
        public ProyectoCreateController(IProyectosRepository ProyectosRepository)
        {
            _ProyectosRepository = ProyectosRepository;
        }
        [HttpPost,Route("api/CrearProyecto")]
        public ActionResult Add([FromBody] Proyecto proyecto){
        _ProyectosRepository.Add(proyecto);
            
            return Ok();
        }
    }
}