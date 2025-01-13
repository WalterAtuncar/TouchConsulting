using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Log
{
    public string VLogId { get; set; } = null!;

    public int? INodeLogId { get; set; }

    public int? IEventTypeId { get; set; }

    public string? VOrganizationId { get; set; }

    public DateTime? DDate { get; set; }

    public int? ISystemUserId { get; set; }

    public string? VProcessEntity { get; set; }

    public string? VElementItem { get; set; }

    public int? ISuccess { get; set; }

    public string? VErrorException { get; set; }

    public string? VComentaryUpdate { get; set; }
}
