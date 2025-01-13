using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Planintegral
{
    public string VPlanIntegral { get; set; } = null!;

    public string? VPersonId { get; set; }

    public int? ITipoId { get; set; }

    public string? VDescripcion { get; set; }

    public DateTime? DFecha { get; set; }

    public string? VLugar { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }
}
