using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Restriction
{
    public string VRestrictionId { get; set; } = null!;

    public string? VDiagnosticRepositoryId { get; set; }

    public string? VServiceId { get; set; }

    public string? VComponentId { get; set; }

    public string? VMasterRestrictionId { get; set; }

    public DateOnly? DStartDateRestriction { get; set; }

    public DateOnly? DEndDateRestriction { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Component? VComponent { get; set; }

    public virtual Diagnosticrepository? VDiagnosticRepository { get; set; }

    public virtual Service? VService { get; set; }
}
