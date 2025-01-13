﻿using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Area
{
    public string VAreaId { get; set; } = null!;

    public string? VLocationId { get; set; }

    public string? VName { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Ge> Ges { get; set; } = new List<Ge>();

    public virtual Location? VLocation { get; set; }
}
