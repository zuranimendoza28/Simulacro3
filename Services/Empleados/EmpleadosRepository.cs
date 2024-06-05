using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simulacro3.Data;
using Simulacro3.Models;
using Simulacro3.DTO;

namespace Simulacro3.Services.Empleados
{
    public class EmpleadosRepository : IEmpleadosRepository
    {
               private readonly GestionContext _context;
        public EmpleadosRepository(GestionContext context)
        {
            _context = context;
        }
        //crear
        public void Add(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }
       //listar
        public async Task<IEnumerable<Empleado>> GetAll()
        {
            return await _context.Empleados.ToListAsync();
        }
        //buscar por id
        public async  Task <Empleado> GetById(int id)
        {
            return await _context.Empleados.FindAsync(id);
        }
        //actualizar
        public void Update(Empleado Empleado)
        {
            _context.Empleados.Update(Empleado);
            _context.SaveChanges();
        } 
        //Cambiar de estado
         public async Task delete(int Id, EmpleadoDto EmpleadoDto)
        {
            var empleados = await _context.Empleados.FindAsync(Id);
            if (empleados == null)
            {
                return;
            }
            empleados.Estado = EmpleadoDto.Estado;

            await _context.SaveChangesAsync();    
        }  
    }
}