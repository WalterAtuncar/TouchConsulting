using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Rolenodecomponentprofile
{
    public string VRoleNodeComponentId { get; set; } = null!;

    public int? INodeId { get; set; }

    public int? IRoleId { get; set; }

    public string? VComponentId { get; set; }

    public int? IRead { get; set; }

    public int? IWrite { get; set; }

    public int? IDx { get; set; }

    public int? IApproved { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Rolenode? Rolenode { get; set; }

    public virtual Component? VComponent { get; set; }
}
