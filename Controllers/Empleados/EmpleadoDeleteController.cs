using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro3.Services.Empleados;

namespace Simulacro3.Controllers.Empleados
{
    public class EmpleadoDeleteController
    {
        private readonly IEmpleadosRepository _EmpleadosRepository;
        public EmpleadoDeleteController(IEmpleadosRepository EmpleadosRepository)
        {
            _EmpleadosRepository = EmpleadosRepository;
        }
    }
}