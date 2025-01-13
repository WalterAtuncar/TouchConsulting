using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Medication
{
    public string VMedicationId { get; set; } = null!;

    public string? VServiceId { get; set; }

    public string? VProductId { get; set; }

    public string? VProductName { get; set; }

    public string? VPresentationName { get; set; }

    public float? RQuantity { get; set; }

    public float? RQuantityVendida { get; set; }

    public string? VDoses { get; set; }

    public int? IViaId { get; set; }

    public int? ISeVendio { get; set; }

    public int? ISeCreoAca { get; set; }

    public string? VTipoDocVenta { get; set; }

    public string? VNroDocVenta { get; set; }

    public decimal? DPrecioVenta { get; set; }

    public string? VMedioPago { get; set; }

    public string? VVendedor { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Service? VService { get; set; }
}
