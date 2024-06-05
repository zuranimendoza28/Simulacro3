using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Especialidades;

namespace Simulacro3.Controllers.Especialidades
{
    public class EspecialidadesController : ControllerBase
    {
        private readonly IEspecialidadesRepository _EspecialidadesRepository;
        public EspecialidadesController(IEspecialidadesRepository EspecialidadesRepository)
        {
            _EspecialidadesRepository = EspecialidadesRepository;
        }
        [HttpGet, Route("api/Especialidades")]
        public async Task<IEnumerable<Especialidad>> GetAll()
        {
            return await _EspecialidadesRepository.GetAll();
        }
        [HttpGet, Route("api/Especialidades/{Id}")]
        public async Task<Especialidad> Get(int Id)
        {
        return await _EspecialidadesRepository.GetById(Id);
        }
    }
}