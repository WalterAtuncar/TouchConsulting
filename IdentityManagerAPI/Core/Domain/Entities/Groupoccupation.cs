using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Groupoccupation
{
    public string VGroupOccupationId { get; set; } = null!;

    public string? VLocationId { get; set; }

    public string? VName { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Occupation> Occupations { get; set; } = new List<Occupation>();

    public virtual Location? VLocation { get; set; }
}
