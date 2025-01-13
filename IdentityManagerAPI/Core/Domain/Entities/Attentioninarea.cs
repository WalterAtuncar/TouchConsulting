using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Attentioninarea
{
    public string VAttentionInAreaId { get; set; } = null!;

    public int INodeId { get; set; }

    public string? VName { get; set; }

    public string? VOfficeNumber { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Attentioninareacomponent> Attentioninareacomponents { get; set; } = new List<Attentioninareacomponent>();

    public virtual Node INode { get; set; } = null!;
}
