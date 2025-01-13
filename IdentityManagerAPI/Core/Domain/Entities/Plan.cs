using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Plan
{
    public int IPlanId { get; set; }

    public string? VOrganizationSeguroId { get; set; }

    public string? VProtocoloId { get; set; }

    public string? VIdUnidadProductiva { get; set; }

    public int? IEsDeducible { get; set; }

    public int? IEsCoaseguro { get; set; }

    public decimal? DImporte { get; set; }

    public decimal? DImporteCo { get; set; }

    public string? VComentaryUpdate { get; set; }
}
