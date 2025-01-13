using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Liquidacion
{
    public string VLiquidacionId { get; set; } = null!;

    public string? VNroLiquidacion { get; set; }

    public string? VOrganizationId { get; set; }

    public decimal? DMonto { get; set; }

    public DateTime? DFechaVencimiento { get; set; }

    public string? VNroFactura { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VServiceId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Organization? VOrganization { get; set; }
}
