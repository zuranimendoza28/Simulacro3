using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro3.Services.Departamentos;

namespace Simulacro3.Controllers.Departamentos
{
    public class DepartamentoDeleteController
    {
        private readonly IDepartamentosRepository _DepartamentosRepository;
        public DepartamentoDeleteController(IDepartamentosRepository DepartamentosRepository)
        {
            _DepartamentosRepository = DepartamentosRepository;
        } 
    }
}