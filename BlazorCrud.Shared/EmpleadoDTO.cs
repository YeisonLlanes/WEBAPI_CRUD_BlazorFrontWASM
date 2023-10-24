using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorCrud.Shared
{
    public class EmpleadoDTO
    {
        public int IdEmpleado { get; set; }

        [Required(ErrorMessage ="* Obligatorio")]
        public string Nombre { get; set; } = null!;
        
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="* Obligatorio")]
        public int IdDepartamento { get; set; }
        
        [Required(ErrorMessage = "* Obligatorio")]
        public int Sueldo { get; set; }

        [Required(ErrorMessage = "* Obligatorio")]
        public DateTime FechaIngreso { get; set; }
        
        public DepartamentoDTO? Departamento { get; set; }
    }
}
