using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simulacro3.Data;
using Simulacro3.Models;
using Simulacro3.DTO;

namespace Simulacro3.Services.Proyectos
{
    public class ProyectosRepository : IProyectosRepository
    {
         private readonly GestionContext _context;
        public ProyectosRepository(GestionContext context)
        {
            _context = context;
        }
        //crear
        public void Add(Proyecto Proyecto)
        {
            _context.Proyectos.Add(Proyecto);
            _context.SaveChanges();
        }
        //listar
        public async Task<IEnumerable<Proyecto>> GetAll()
        {
            return await _context.Proyectos.ToListAsync();
        }
        //buscar por id
        public async  Task <Proyecto> GetById(int id)
        {
            return await _context.Proyectos.FindAsync(id);
        }  
        //actualizar
        public void Update(Proyecto Proyecto)
        {
            _context.Proyectos.Update(Proyecto);
            _context.SaveChanges();
        } 
        //Cambiar de estado
        public async Task delete(int Id, ProyectoDto ProyectoDto)
        {
            var proyectos = await _context.Proyectos.FindAsync(Id);
            if (proyectos == null)
            {
                return;
            }
            proyectos.Estado = ProyectoDto.Estado;

            await _context.SaveChangesAsync();    
        } 
    }
}