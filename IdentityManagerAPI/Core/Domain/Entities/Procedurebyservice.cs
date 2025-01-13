using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Procedurebyservice
{
    public string VProcedureByServiceId { get; set; } = null!;

    public string? VServiceId { get; set; }

    public int? IProcedureId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IProcedureTypeId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Service? VService { get; set; }
}
