using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Pacient
{
    public string VPersonId { get; set; } = null!;

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IUpdateNodeId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Pacientmultimediadatum> Pacientmultimediadata { get; set; } = new List<Pacientmultimediadatum>();

    public virtual Person VPerson { get; set; } = null!;
}
