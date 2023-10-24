using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.Shared
{
    public class DepartamentoDTO
    {
        public int IdDepartamento { get; set; }
        
        [Required(ErrorMessage ="* Obligatorio")]
        public string Descripcion { get; set; } = null!;
    }
}
