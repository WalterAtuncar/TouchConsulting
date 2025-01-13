using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Configdx
{
    public string VConfigDxId { get; set; } = null!;

    public string? VDiseaseId { get; set; }

    public string? VProductId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
