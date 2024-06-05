using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro3.DTO;
using Simulacro3.Models;

namespace Simulacro3.Services.Departamentos
{
    public interface IDepartamentosRepository
    {
        Task<IEnumerable<Departamento>> GetAll();
        Task<Departamento> GetById(int id);  
        void Add(Departamento departamento);
        void Update( Departamento departamento);
        Task Delete(int id, DepartamentoDto departamentoDto); 
    }
}