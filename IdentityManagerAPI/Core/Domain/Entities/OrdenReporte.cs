using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class OrdenReporte
{
    public string VOrdenReporteId { get; set; } = null!;

    public string? VOrganizationId { get; set; }

    public string? VNombreReporte { get; set; }

    public string? VComponenteId { get; set; }

    public int? IOrden { get; set; }

    public string? VNombreCrystal { get; set; }

    public int? INombreCrystalId { get; set; }

    public string? VComentaryUpdate { get; set; }
}
