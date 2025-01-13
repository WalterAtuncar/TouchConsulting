using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Restrictedwarehouseprofile
{
    public int ISystemUserId { get; set; }

    public string VWarehouseId { get; set; } = null!;

    public int INodeId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Warehouse VWarehouse { get; set; } = null!;
}
