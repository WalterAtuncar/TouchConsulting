using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Marking
{
    public int IDialingId { get; set; }

    public string? VPersonId { get; set; }

    public DateTime? DDialingDate { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VTypeMarking { get; set; }

    public int? IPaidOut { get; set; }

    public TimeOnly? TExtraHours { get; set; }

    public TimeOnly? THoursAgainst { get; set; }

    public string? VScheduleDetailId { get; set; }
}
