using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Empleados;

namespace Simulacro3.Controllers.Empleados
{
    public class EmpleadoCreateController : ControllerBase
    {
        private readonly IEmpleadosRepository _EmpleadosRepository;
        public EmpleadoCreateController(IEmpleadosRepository EmpleadosRepository)
        {
            _EmpleadosRepository = EmpleadosRepository;
        }
        [HttpPost,Route("api/CrearEmpleados")]
        public ActionResult Add([FromBody] Empleado empleado){
        _EmpleadosRepository.Add(empleado);
            
            return Ok();
        }

    }
}