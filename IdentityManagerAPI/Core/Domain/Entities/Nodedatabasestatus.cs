using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Nodedatabasestatus
{
    public int INodeId { get; set; }

    public string? VCurrentDatabaseVersion { get; set; }

    public string? VPreviousDatabaseVersion { get; set; }

    public int? ICurrentDatabaseStatus { get; set; }

    public DateTime? DLastDatabaseUpgrade { get; set; }

    public DateTime? DLastDatabaseDataSync { get; set; }

    public string? VComentaryUpdate { get; set; }
}
