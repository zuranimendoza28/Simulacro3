using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Empleados;

namespace Simulacro3.Controllers.Empleados
{
    public class EmpleadoUpdateController : ControllerBase
    {
        private readonly IEmpleadosRepository _EmpleadosRepository;
        public EmpleadoUpdateController(IEmpleadosRepository EmpleadosRepository)
        {
            _EmpleadosRepository = EmpleadosRepository;
        }
        [HttpPut]
        [Route("api/Empleados/update/{id}")]
        public IActionResult Update([FromBody] Empleado empleado){
        
        _EmpleadosRepository.Update(empleado);
            return Ok("Se actualizo correctamente");
      }
    }
}