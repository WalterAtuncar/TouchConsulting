using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Workersscheduledetail
{
    public string VScheduleDetailId { get; set; } = null!;

    public string? VScheduleId { get; set; }

    public string? VPersonId { get; set; }

    public DateTime? DDate { get; set; }

    public TimeOnly? TStartDate { get; set; }

    public TimeOnly? TStartBreak { get; set; }

    public TimeOnly? TEndBreak { get; set; }

    public TimeOnly? TEndDate { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
