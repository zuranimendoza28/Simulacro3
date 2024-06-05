using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro3.Models
{
    public class Proyecto
    {
    public int Id { get; set; }
    [Required]
    public string Nombre { get; set; }
    [Required]
    public DateTime FechaInicio { get; set; }
    public DateTime? FechaFin { get; set; }
    [Required]
    public string Estado { get; set; }
    public List<Tarea> Tareas { get; set; } 
    }
}