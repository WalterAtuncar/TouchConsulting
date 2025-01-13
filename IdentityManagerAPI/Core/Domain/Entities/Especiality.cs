using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Especiality
{
    public string VEspecialityId { get; set; } = null!;

    public string? VEspecialityName { get; set; }

    public byte[]? BEspecialityPicture { get; set; }

    public TimeOnly? TTimeForAttention { get; set; }

    public decimal? RCost { get; set; }

    public string? VDescription { get; set; }

    public int? IIsDeleted { get; set; }

    public TimeOnly? TStartTime { get; set; }

    public TimeOnly? TEndTime { get; set; }

    public TimeOnly? TStartTime2 { get; set; }

    public TimeOnly? TEndTime2 { get; set; }

    public string? VProtocolId { get; set; }
}
