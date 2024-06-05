using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simulacro3.Models;
using Simulacro3.Services.Tareas;

namespace Simulacro3.Controllers.Tareas
{
    public class TareaController : ControllerBase
    {
         private readonly ITareasRepository _TareasRepository;
        public TareaController(ITareasRepository TareasRepository)
        {
            _TareasRepository = TareasRepository;
        }
        [HttpGet, Route("api/Tareas")]
        public async Task<IEnumerable<Tarea>> GetAll()
        {
            return await _TareasRepository.GetAll();
        }
        [HttpGet, Route("api/Tareas/{Id}")]
        public async Task<Tarea> Get(int Id)
        {
        return await _TareasRepository.GetById(Id);
        }

        [HttpGet, Route("api/TareaEmpleado/{id}")]
         public IEnumerable<Tarea> get(int id)
        {
            return _TareasRepository.GetByEmpleadoId(id);
        }

        [HttpGet, Route("api/TareaDate/{id}")]

        public IEnumerable<Tarea> Get(int id, DateTime date)
        {
           
            return _TareasRepository.GetByEmpleadoIdAndDate(id, date);
        }

        

    }
}