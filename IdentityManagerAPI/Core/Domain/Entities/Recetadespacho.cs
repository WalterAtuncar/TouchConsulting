using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Recetadespacho
{
    public int IIdDespacho { get; set; }

    public int? IIdReceta { get; set; }

    public decimal? DMontoDespachado { get; set; }

    public DateTime? TFechaDespacho { get; set; }

    public string? VComentaryUpdate { get; set; }
}
