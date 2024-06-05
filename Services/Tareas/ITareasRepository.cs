using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro3.DTO;
using Simulacro3.Models;

namespace Simulacro3.Services.Tareas
{
    public interface ITareasRepository
    {
        Task<IEnumerable<Tarea>> GetAll();
        Task<Tarea> GetById(int id);  
        void Add(Tarea Tarea);
        void Update(Tarea Tarea);
        Task delete(int Id, TareaDto tareaDto); 
         public IEnumerable<Tarea> GetByEmpleadoId(int id);
         public IEnumerable<Tarea> GetByEmpleadoIdAndDate(int id, DateTime date);
          public IEnumerable<Tarea> GetByDate(DateTime date);
        public IEnumerable<Tarea> GetByProyectoId(int id);

    }
}