using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Rolenode
{
    public int INodeId { get; set; }

    public int IRoleId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Node INode { get; set; } = null!;

    public virtual ICollection<Rolenodecomponentprofile> Rolenodecomponentprofiles { get; set; } = new List<Rolenodecomponentprofile>();

    public virtual ICollection<Rolenodeprofile> Rolenodeprofiles { get; set; } = new List<Rolenodeprofile>();

    public virtual ICollection<Systemuserrolenode> Systemuserrolenodes { get; set; } = new List<Systemuserrolenode>();
}
