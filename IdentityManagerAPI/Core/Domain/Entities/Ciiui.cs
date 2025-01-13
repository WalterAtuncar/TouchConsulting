using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Ciiui
{
    public string VCiiuid { get; set; } = null!;

    public string? VCiiudescription1 { get; set; }

    public string? VCiiudescription2 { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }
}
