using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Attentioninareacomponent
{
    public string VAttentioninAreaComponentId { get; set; } = null!;

    public string? VAttentionInAreaId { get; set; }

    public string? VComponentId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Attentioninarea? VAttentionInArea { get; set; }

    public virtual Component? VComponent { get; set; }
}
