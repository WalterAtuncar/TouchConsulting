using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Calendar
{
    public string VCalendarId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VServiceId { get; set; }

    public DateTime? DDateTimeCalendar { get; set; }

    public DateTime? DCircuitStartDate { get; set; }

    public DateTime? DEntryTimeCm { get; set; }

    public int? IServiceTypeId { get; set; }

    public int? ICalendarStatusId { get; set; }

    public int? IServiceId { get; set; }

    public string? VProtocolId { get; set; }

    public int? INewContinuationId { get; set; }

    public int? ILineStatusId { get; set; }

    public int? IIsVipId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public DateTime? DSalidaCm { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Person? VPerson { get; set; }

    public virtual Service? VService { get; set; }
}
