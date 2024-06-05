using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro3.Services.Especialidades;

namespace Simulacro3.Controllers.Especialidades
{
    public class EspecialidadesDeleteController
    {
        private readonly IEspecialidadesRepository _EspecialidadesRepository;
        public EspecialidadesDeleteController(IEspecialidadesRepository EspecialidadesRepository)
        {
            _EspecialidadesRepository = EspecialidadesRepository;
        }

    }
}