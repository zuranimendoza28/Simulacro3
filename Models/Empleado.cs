using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro3.Models
{
    public class Empleado
    {
        public int Id { get; set; }
    [Required]
    public string Nombre { get; set; }
    [Required]
    public string Estado {get; set;}
    public int DepartamentoId { get; set; }
    public Departamento Departamento { get; set; }
    public string Correo {get; set;}
    public List<Tarea> Tareas { get; set; }
    }
}