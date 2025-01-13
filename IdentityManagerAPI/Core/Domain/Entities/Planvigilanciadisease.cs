using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Planvigilanciadisease
{
    public string VPlanVigilanciaDiseasesId { get; set; } = null!;

    public string? VPlanVigilanciaId { get; set; }

    public string? VDiseasesId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Disease? VDiseases { get; set; }

    public virtual Planvigilancium? VPlanVigilancia { get; set; }
}
