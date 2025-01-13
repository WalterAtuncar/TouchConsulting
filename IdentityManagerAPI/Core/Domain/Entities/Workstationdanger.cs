using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Workstationdanger
{
    public string VWorkstationDangersId { get; set; } = null!;

    public string? VHistoryId { get; set; }

    public int? IDangerId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? INoiseSource { get; set; }

    public int? INoiseLevel { get; set; }

    public string? VTimeOfExposureToNoise { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual History? VHistory { get; set; }
}
