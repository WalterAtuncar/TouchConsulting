using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Planvigilancium
{
    public string VPlanVigilanciaId { get; set; } = null!;

    public string? VName { get; set; }

    public string? VDescription { get; set; }

    public string? VOrganizationId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual ICollection<Planvigilanciadisease> Planvigilanciadiseases { get; set; } = new List<Planvigilanciadisease>();

    public virtual ICollection<Vigilancium> Vigilancia { get; set; } = new List<Vigilancium>();
}
