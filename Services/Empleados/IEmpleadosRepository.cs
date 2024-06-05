using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro3.DTO;
using Simulacro3.Models;
namespace Simulacro3.Services.Empleados
{
    public interface IEmpleadosRepository
    {
        Task<IEnumerable<Empleado>> GetAll();
        Task<Empleado> GetById(int id);  
        void Add(Empleado empleado);
        void Update(Empleado empleado);
        Task delete(int id,EmpleadoDto EmpleadoDto);    
    }
}