using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Blacklistperson
{
    public string VBlackListPerson { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VComment { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IStatus { get; set; }

    public DateOnly? DDateRegister { get; set; }

    public DateOnly? DDateDetection { get; set; }

    public DateOnly? DDateSolution { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Person? VPerson { get; set; }
}
