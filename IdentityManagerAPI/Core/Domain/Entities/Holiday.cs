using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Holiday
{
    public string VHolidayId { get; set; } = null!;

    public int? IYear { get; set; }

    public DateOnly? DDate { get; set; }

    public string? VReason { get; set; }

    public int? IIsDeleted { get; set; }
}
