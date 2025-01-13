using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Nodeorganizationlocationprofile
{
    public int INodeId { get; set; }

    public string VOrganizationId { get; set; } = null!;

    public string VLocationId { get; set; } = null!;

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Node INode { get; set; } = null!;

    public virtual Location VLocation { get; set; } = null!;

    public virtual Organization VOrganization { get; set; } = null!;
}
