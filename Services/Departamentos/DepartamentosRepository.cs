using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simulacro3.Data;
using Simulacro3.Models;
using Simulacro3.DTO;

namespace Simulacro3.Services.Departamentos
{
    public class DepartamentosRepository : IDepartamentosRepository
    {
        
        private readonly GestionContext _context;
        public DepartamentosRepository(GestionContext context)
        {
            _context = context;
        }
        //crear
        public void Add(Departamento Departamento)
        {
            _context.Departamentos.Add(Departamento);
            _context.SaveChanges();
        }
        //listar
        public async Task<IEnumerable<Departamento>> GetAll()
        {
            return await _context.Departamentos.ToListAsync();
        }
        //buscar por id
        public async  Task <Departamento> GetById(int id)
        {
            return await _context.Departamentos.FindAsync(id);
        }
        //actualizar
        public void Update(Departamento Departamento)
        {
            _context.Departamentos.Update(Departamento);
            _context.SaveChanges();
        } 
        //Cambiar de estado
          public async Task Delete(int Id, DepartamentoDto DepartamentoDto)
        {
            var departamentos = await _context.Departamentos.FindAsync(Id);
            if (departamentos == null)
            {
                return;
            }
            departamentos.Estado = DepartamentoDto.Estado;

            await _context.SaveChangesAsync();    
        } 
    }
}