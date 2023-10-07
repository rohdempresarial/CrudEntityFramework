using System;
using System.Collections.Generic;

namespace mvccrud4.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public int? Cedula { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? Telefono { get; set; }
}
