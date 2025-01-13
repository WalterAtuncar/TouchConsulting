using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Workersschedule
{
    public string VScheduleId { get; set; } = null!;

    public string? VScheduleName { get; set; }

    public string? VScheduleDescription { get; set; }

    public string? VMes { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
