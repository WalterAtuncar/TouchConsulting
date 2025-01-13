using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Notification
{
    public string VNotificationId { get; set; } = null!;

    public string? VOrganizationId { get; set; }

    public DateTime? DNotificationDate { get; set; }

    public string? VPersonId { get; set; }

    public string? VTitle { get; set; }

    public string? VBody { get; set; }

    public int? IIsRead { get; set; }

    public int? ITypeNotificationId { get; set; }

    public DateTime? DScheduleDate { get; set; }

    public int? IStateNotificationId { get; set; }

    public string? VPath { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
