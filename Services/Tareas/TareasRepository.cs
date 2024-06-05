using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simulacro3.Data;
using Simulacro3.Models;
using Simulacro3.Utils;
using Simulacro3.DTO;

namespace Simulacro3.Services.Tareas
{
    public class TareasRepository : ITareasRepository
    {
        private readonly GestionContext _context;
        public TareasRepository(GestionContext context)
        {
            _context = context;
        }
        //crear
        public void Add(Tarea tarea)
        {
            
            var Empleado = _context.Empleados.Find(tarea.EmpleadoId);
            var sendEmail = new MailersendUtils();
            //se utiliza el metodo .Enviarcorreo(), se envia como parametro el email   del paciente y la fecha de la cita:
            sendEmail.EnviarCorreo(Empleado.Correo, tarea.Descripcion, Empleado.Nombre);
            _context.Tareas.Add(tarea);
            _context.SaveChanges();

        }
    //listar
        public async Task<IEnumerable<Tarea>> GetAll()
        {
            return await _context.Tareas.Where(e => e.Estado == "Activo").ToListAsync();
        }
        //buscar por id
        public async Task <Tarea> GetById(int id)
        {
            return await _context.Tareas.FindAsync(id);
        }
        //actualizar
        public void Update(Tarea Tarea)
        {
            _context.Tareas.Remove(Tarea);
            _context.SaveChanges();
        } 
        //Cambiar de estado
         public async Task delete(int Id, TareaDto TareaDto)
        {
            var tareas = await _context.Tareas.FindAsync(Id);
            if (tareas == null)
            {
                return;
            }
            tareas.Estado = TareaDto.Estado;

            await _context.SaveChangesAsync();    
        } 

        //Endpoints adicionales

        //1. listar la cantidad de tareas de un empleado
        public IEnumerable<Tarea> GetByEmpleadoId(int id)
        {
            var Tareas = _context.Tareas.Include(p => p.Proyecto).Include(e => e.Empleado).Where(t => t.EmpleadoId == id );
            return Tareas;
        }

        //2.Listar las tareas de un empleado en determinado dia
        public IEnumerable<Tarea> GetByEmpleadoIdAndDate(int id, DateTime date)
        {
            var TareasDia = _context.Tareas.Include(p => p.Proyecto).Include(e => e.Empleado).Where(t => t.EmpleadoId == id && t.FechaAsignacion == date);
            return TareasDia;
        }

        //3. Listar todas las tareas de determinado dia
        public IEnumerable<Tarea> GetByDate(DateTime date)
        {
            var TodasTareas = _context.Tareas.Include(p => p.Proyecto).Include(e => e.Empleado).Where(t => t.FechaAsignacion == date);
            return TodasTareas;
        }

        //4 Listar el historial de las tareas de proyecto
        public IEnumerable<Tarea> GetByProyectoId(int id)
        {
            var Historial = _context.Tareas.Include(p => p.Proyecto).Include(e => e.Empleado).Where(t => t.ProyectoId == id);
            return Historial;
        }


    }
}


///consultas basicas 
/* Obtener Todos los Registros:
var employees = await _context.Employees.ToListAsync(); */

//---------------------------------------

/* Filtrar Registros: 
var employees = await _context.Employees
    .Where(e => e.DepartmentId == 1)
    .ToListAsync();
 */

 //---------------------------------------

 /*  Obtener el Primer Registro o un Valor Predeterminado
  var employee = await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == 1) */

 //---------------------------------------
/*  Seleccionar Campos Específicos:
 var employeeNames = await _context.Employees
    .Select(e => new { e.FirstName, e.LastName })
    .ToListAsync(); */

//-----------------------------------------
/* Incluir Relaciones:
var employees = await _context.Employees
    .Include(e => e.Department)
    .ToListAsync(); */

//-----------------------------------------
/* Incluir Relaciones Anidadas:
var employees = await _context.Employees
    .Include(e => e.Department)
    .ThenInclude(d => d.Company)
    .ToListAsync(); */

//-----------------------------------------
/* Obtener un Solo Registro
var employee = await _context.Employees
    .SingleOrDefaultAsync(e => e.Email == "example@example.com"); */