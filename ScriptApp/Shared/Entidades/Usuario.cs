using System;
using System.Collections.Generic;

namespace ScriptApp.Shared.Entidades;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Script> Scripts { get; set; } = new List<Script>();
}
