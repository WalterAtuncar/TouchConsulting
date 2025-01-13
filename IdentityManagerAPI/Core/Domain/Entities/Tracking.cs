using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Tracking
{
    public string VSeguroId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public int? IAgenda { get; set; }

    public int? ICartaGarantia { get; set; }

    public int? IAtencionMedica { get; set; }

    public int? IPreLiquidacion { get; set; }

    public int? IControlCalidad { get; set; }

    public int? IFacturacion { get; set; }

    public int? ICulminado { get; set; }

    public string? VServiceId { get; set; }
}
