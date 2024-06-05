using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Especialidades;

namespace Simulacro3.Controllers.Especialidades
{
    public class EspecialidadesUpdateController : ControllerBase
    {
        private readonly IEspecialidadesRepository _EspecialidadesRepository;
        public EspecialidadesUpdateController(IEspecialidadesRepository EspecialidadesRepository)
        {
            _EspecialidadesRepository = EspecialidadesRepository;
        }

        [HttpPut]
        [Route("api/Especialidades/update/{id}")]
        public IActionResult Update([FromBody] Especialidad especialidad){
        
        _EspecialidadesRepository.Update(especialidad);
            return Ok("Se actualizo correctamente");
      }
    }
}