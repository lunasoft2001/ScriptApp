using System;
using System.Collections.Generic;

namespace ScriptApp.Shared.Entidades;

public partial class ScriptDetalle
{
    public int Id { get; set; }

    public int? ScriptId { get; set; }

    public string? Titulo { get; set; }

    public string Codigo { get; set; } = null!;
}
