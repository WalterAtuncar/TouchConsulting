using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Servernodesync
{
    public int INodeId { get; set; }

    public string? VDataSyncVersion { get; set; }

    public int? IDataSyncFrecuency { get; set; }

    public int? IEnabled { get; set; }

    public DateTime? DLastSuccessfulDataSync { get; set; }

    public int? ILastServerProcessStatus { get; set; }

    public int? ILastNodeProcessStatus { get; set; }

    public DateTime? DNextDataSync { get; set; }

    public string? VLastServerPackageFileName { get; set; }

    public string? VLastServerProcessErrorMessage { get; set; }

    public string? VLastNodePackageFileName { get; set; }

    public string? VLastNodeProcessErrorMessage { get; set; }

    public string? VComentaryUpdate { get; set; }
}
