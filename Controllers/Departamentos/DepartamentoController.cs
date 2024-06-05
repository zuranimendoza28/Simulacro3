using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Departamentos;

namespace Simulacro3.Controllers.Departamentos
{
    public class DepartamentoController : ControllerBase
    {
        private readonly IDepartamentosRepository _DepartamentosRepository;
        public DepartamentoController(IDepartamentosRepository DepartamentosRepository)
        {
            _DepartamentosRepository = DepartamentosRepository;
        }
        [HttpGet, Route("api/Departamentos")]
        public async Task<IEnumerable<Departamento>> GetAll()
        {
            return await _DepartamentosRepository.GetAll();
        }
        [HttpGet, Route("api/Departamentos/{Id}")]
        public async Task<Departamento> Get(int Id)
        {
        return await _DepartamentosRepository.GetById(Id);
        }

    }
}