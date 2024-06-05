using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro3.Services.Proyectos;

namespace Simulacro3.Controllers.Proyectos
{
    public class ProyectoDeleteController
    {
        private readonly IProyectosRepository _ProyectosRepository;
        public ProyectoDeleteController(IProyectosRepository ProyectosRepository)
        {
            _ProyectosRepository = ProyectosRepository;
        }
    }
}