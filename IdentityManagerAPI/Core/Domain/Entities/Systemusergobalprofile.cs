using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Systemusergobalprofile
{
    public int ISystemUserId { get; set; }

    public int IApplicationHierarchyId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Applicationhierarchy IApplicationHierarchy { get; set; } = null!;
}
