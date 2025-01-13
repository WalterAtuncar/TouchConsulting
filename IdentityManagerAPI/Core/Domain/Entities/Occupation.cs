using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Occupation
{
    public string VOccupationId { get; set; } = null!;

    public string? VGesId { get; set; }

    public string? VGroupOccupationId { get; set; }

    public string? VName { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Ge? VGes { get; set; }

    public virtual Groupoccupation? VGroupOccupation { get; set; }
}
