using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro3.DTO;
using Simulacro3.Models;

namespace Simulacro3.Services.Proyectos
{
    public interface IProyectosRepository
    {
        Task<IEnumerable<Proyecto>> GetAll();
        Task<Proyecto> GetById(int id);  
        void Add(Proyecto proyecto);
        void Update(Proyecto proyecto);
        Task delete(int id,ProyectoDto proyectoDto);  
    }
}