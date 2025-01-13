using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Facturaciondetalle
{
    public string VFacturacionDetalleId { get; set; } = null!;

    public string? VFacturacionId { get; set; }

    public string? VServicioId { get; set; }

    public decimal? DMonto { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Facturacion? VFacturacion { get; set; }
}
