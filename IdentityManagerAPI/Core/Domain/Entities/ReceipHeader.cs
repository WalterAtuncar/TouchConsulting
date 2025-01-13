using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class ReceipHeader
{
    public string VReceipId { get; set; } = null!;

    public string? VServiceId { get; set; }

    public int? IMedicoId { get; set; }

    public string? VMedicoName { get; set; }

    public float? DTotal { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
