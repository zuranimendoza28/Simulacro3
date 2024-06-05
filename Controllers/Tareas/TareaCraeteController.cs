using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Tareas;

namespace Simulacro3.Controllers.Tareas
{
    public class TareaCraeteController : ControllerBase
    {
        private readonly ITareasRepository _TareasRepository;
        public TareaCraeteController(ITareasRepository TareasRepository)
        {
            _TareasRepository = TareasRepository;
        }
        [HttpPost,Route("api/CrearTarea")]
        public ActionResult Add([FromBody] Tarea tarea){
        _TareasRepository.Add(tarea);
            
            return Ok();
        }
    }
}