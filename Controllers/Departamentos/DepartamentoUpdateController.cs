using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Departamentos;

namespace Simulacro3.Controllers.Departamentos
{
    public class DepartamentoUpdateController : ControllerBase
    {
        private readonly IDepartamentosRepository _DepartamentosRepository;
        public DepartamentoUpdateController(IDepartamentosRepository DepartamentosRepository)
        {
            _DepartamentosRepository = DepartamentosRepository;
        }
        [HttpPut]
        [Route("api/Departamentos/update/{id}")]
        public IActionResult Update([FromBody] Departamento departamento){
        
        _DepartamentosRepository.Update(departamento);
            return Ok("Se actualizo correctamente");
      }
    }
}