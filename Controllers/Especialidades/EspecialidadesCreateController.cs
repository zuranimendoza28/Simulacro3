using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Especialidades;

namespace Simulacro3.Controllers.Especialidades
{
    public class EspecialidadesCreateController : ControllerBase
    {
        private readonly IEspecialidadesRepository _EspecialidadesRepository;
        public EspecialidadesCreateController(IEspecialidadesRepository EspecialidadesRepository)
        {
            _EspecialidadesRepository = EspecialidadesRepository;
        }
        [HttpPost,Route("api/CrearEspecialidades")]
        public ActionResult Add([FromBody] Especialidad especialidad){
        _EspecialidadesRepository.Add(especialidad);
            
            return Ok();
        }

    }
}