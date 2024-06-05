using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Departamentos;

namespace Simulacro3.Controllers.Departamentos
{
    public class DepartamentoCreateController : ControllerBase
    {
        private readonly IDepartamentosRepository _DepartamentosRepository;
        public DepartamentoCreateController(IDepartamentosRepository DepartamentosRepository)
        {
            _DepartamentosRepository = DepartamentosRepository;
        }
        [HttpPost,Route("api/CrearDepartamentos")]
        public ActionResult Add([FromBody] Departamento departamento){
        _DepartamentosRepository.Add(departamento);
            
            return Ok();
        }
    }
}