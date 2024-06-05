using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro3.Models
{
    public class Tarea
    {
       public int Id { get; set; }
    [Required]
    public int ProyectoId { get; set; }
    [Required]
    public int EmpleadoId { get; set; }
    [Required]
    public string Descripcion { get; set; }
    [Required]
    public DateTime FechaAsignacion { get; set; }
    [Required]
    public string Estado { get; set; }
    public Proyecto Proyecto { get; set; }
    public Empleado Empleado { get; set; } 
    }
}