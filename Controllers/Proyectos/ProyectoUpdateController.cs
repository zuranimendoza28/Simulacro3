using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Proyectos;

namespace Simulacro3.Controllers.Proyectos
{
    public class ProyectoUpdateController : ControllerBase
    {
        private readonly IProyectosRepository _ProyectosRepository;
        public ProyectoUpdateController(IProyectosRepository ProyectosRepository)
        {
            _ProyectosRepository = ProyectosRepository;
        }
        [HttpPut]
        [Route("api/proyectos/update/{id}")]
        public IActionResult Update([FromBody] Proyecto proyecto){
        
        _ProyectosRepository.Update( proyecto);
            return Ok("Se actualizo correctamente");
      }
    }
}