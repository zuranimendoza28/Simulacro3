using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro3.Services.Tareas;

namespace Simulacro3.Controllers.Tareas
{
    public class TareaDeleteController
    {
        private readonly ITareasRepository _TareasRepository;
        public TareaDeleteController(ITareasRepository TareasRepository)
        {
            _TareasRepository = TareasRepository;
        }
    }
}