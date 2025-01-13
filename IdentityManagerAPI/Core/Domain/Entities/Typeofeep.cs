using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Typeofeep
{
    public string VTypeofEepid { get; set; } = null!;

    public string? VHistoryId { get; set; }

    public int? ITypeofEepid { get; set; }

    public float? RPercentage { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual History? VHistory { get; set; }
}
