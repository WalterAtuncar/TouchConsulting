using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Productwarehouse
{
    public string VWarehouseId { get; set; } = null!;

    public string VProductId { get; set; } = null!;

    public float? RStockMin { get; set; }

    public float? RStockMax { get; set; }

    public float? RStockActual { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Product VProduct { get; set; } = null!;

    public virtual Warehouse VWarehouse { get; set; } = null!;
}
