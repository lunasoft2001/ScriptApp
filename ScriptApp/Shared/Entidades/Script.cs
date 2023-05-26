using System;
using System.Collections.Generic;

namespace ScriptApp.Shared.Entidades;

public partial class Script
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime Fecha { get; set; }

    public int? UsuarioId { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
