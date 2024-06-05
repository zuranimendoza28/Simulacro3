using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Tareas;

namespace Simulacro3.Controllers.Tareas
{
    public class TareaUpdateController : ControllerBase
    {
        private readonly ITareasRepository _TareasRepository;
        public TareaUpdateController(ITareasRepository TareasRepository)
        {
            _TareasRepository = TareasRepository;
        }
        [HttpPut]
        [Route("api/tareas/update/{id}")]
        public IActionResult Update([FromBody] Tarea tarea){
        
        _TareasRepository.Update( tarea);
            return Ok("Se actualizo correctamente");
      }
    }
}