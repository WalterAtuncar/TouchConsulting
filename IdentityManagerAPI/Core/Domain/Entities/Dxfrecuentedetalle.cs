using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Dxfrecuentedetalle
{
    public string VDxFrecuenteDetalleId { get; set; } = null!;

    public string? VDxFrecuenteId { get; set; }

    public string? VMasterRecommendationRestricctionId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Dxfrecuente? VDxFrecuente { get; set; }
}
