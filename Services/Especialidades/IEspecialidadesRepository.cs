using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro3.DTO;
using Simulacro3.Models;

namespace Simulacro3.Services.Especialidades
{
    public interface IEspecialidadesRepository
    {
        Task<IEnumerable<Especialidad>> GetAll();
        Task<Especialidad> GetById(int id);  
        void Add(Especialidad especialidad);
        void Update(Especialidad especialidad);
        Task delete(int id,EspecialidadDto EspecialidadDto);  
    }
}