using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Nodeserviceprofile
{
    public string VNodeServiceProfileId { get; set; } = null!;

    public int? INodeId { get; set; }

    public int? IServiceTypeId { get; set; }

    public int? IMasterServiceId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Node? INode { get; set; }
}
