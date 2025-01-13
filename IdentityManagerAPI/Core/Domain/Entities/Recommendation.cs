﻿using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Recommendation
{
    public string VRecommendationId { get; set; } = null!;

    public string? VServiceId { get; set; }

    public string? VDiagnosticRepositoryId { get; set; }

    public string? VComponentId { get; set; }

    public string? VMasterRecommendationId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Component? VComponent { get; set; }

    public virtual Diagnosticrepository? VDiagnosticRepository { get; set; }

    public virtual Service? VService { get; set; }
}
