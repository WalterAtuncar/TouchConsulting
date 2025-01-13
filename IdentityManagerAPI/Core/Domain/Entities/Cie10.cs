using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Cie10
{
    public string VCie10id { get; set; } = null!;

    public string? VCie10description1 { get; set; }

    public string? VCie10description2 { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Disease> Diseases { get; set; } = new List<Disease>();

    public virtual ICollection<Dxfrecuente> Dxfrecuentes { get; set; } = new List<Dxfrecuente>();
}
