using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Embarzo
{
    public string VEmbarazoId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VAnio { get; set; }

    public string? VCpn { get; set; }

    public string? VComplicacion { get; set; }

    public string? VParto { get; set; }

    public string? VPesoRn { get; set; }

    public string? VPuerpio { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VObservacionesGestacion { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Person? VPerson { get; set; }
}
