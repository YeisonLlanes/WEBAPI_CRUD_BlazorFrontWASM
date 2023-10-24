using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorCrud.Server.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    [Required(ErrorMessage = "* Obligatorio")]
    public string Nombre { get; set; } = null!;

    public int IdDepartamento { get; set; }

    public int Sueldo { get; set; }

    public DateTime FechaIngreso { get; set; }
    [JsonIgnore]
    public virtual Departamento IdDepartamentoNavigation { get; set; } = null!;
}
