using System;
using System.Collections.Generic;

namespace EjemploREST202251.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Edad { get; set; }

    public float? Sueldo { get; set; }

    public string? Departamento { get; set; }
}
