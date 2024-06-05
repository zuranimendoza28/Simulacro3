using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Empleados;

namespace Simulacro3.Controllers.Empleados
{
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadosRepository _EmpleadosRepository;
        public EmpleadoController(IEmpleadosRepository EmpleadosRepository)
        {
            _EmpleadosRepository = EmpleadosRepository;
        }
        [HttpGet, Route("api/Empleados")]
        public async Task<IEnumerable<Empleado>> GetAll()
        {
            return await _EmpleadosRepository.GetAll();
        }
        [HttpGet, Route("api/Empleados/{Id}")]
        public async Task<Empleado> Get(int Id)
        {
        return await _EmpleadosRepository.GetById(Id);
        }

    }
}