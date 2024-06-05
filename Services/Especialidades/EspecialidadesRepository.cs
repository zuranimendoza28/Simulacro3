using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simulacro3.Data;
using Simulacro3.Models;
using Simulacro3.DTO;

namespace Simulacro3.Services.Especialidades
{
    public class EspecialidadesRepository : IEspecialidadesRepository
    {
        private readonly GestionContext _context;
        public EspecialidadesRepository(GestionContext context)
        {
            _context = context;
        }
        //crear
        public void Add(Especialidad especialidad)
        {
            _context.Especialidades.Add(especialidad);
            _context.SaveChanges();
        }
        //listar
        public async Task<IEnumerable<Especialidad>> GetAll()
        {
            return await _context.Especialidades.ToListAsync();
        }
        //buscar por id
        public async  Task <Especialidad> GetById(int id)
        {
            return await _context.Especialidades.FindAsync(id);
        }
        //actualizar
        public void Update(Especialidad especialidad)
        {
            _context.Especialidades.Update(especialidad);
            _context.SaveChanges();
        } 
        //Cambiar de estado
        public async Task delete(int Id, EspecialidadDto EspecialidadDto)
        {
            var especialidades = await _context.Especialidades.FindAsync(Id);
            if (especialidades == null)
            {
                return;
            }
            especialidades.Estado = EspecialidadDto.Estado;

            await _context.SaveChangesAsync();    
        }  
    }
}