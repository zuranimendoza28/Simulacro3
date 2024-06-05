using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simulacro3.Models;

namespace Simulacro3.Data 
{
    public class GestionContext  : DbContext
    {
        public GestionContext(DbContextOptions<GestionContext> options) : base(options){
    } 
         public DbSet<Proyecto> Proyectos { get; set; } 
         public DbSet<Tarea> Tareas { get; set; }
         public DbSet<Empleado> Empleados { get; set; }
         public DbSet<Especialidad> Especialidades { get; set; }
         public DbSet<Departamento> Departamentos { get; set; }
    }
}
