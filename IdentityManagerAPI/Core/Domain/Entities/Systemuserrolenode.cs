using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Systemuserrolenode
{
    public int ISystemUserId { get; set; }

    public int INodeId { get; set; }

    public int IRoleId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Rolenode Rolenode { get; set; } = null!;
}
