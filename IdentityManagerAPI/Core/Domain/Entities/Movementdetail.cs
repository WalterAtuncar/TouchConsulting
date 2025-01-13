using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Movementdetail
{
    public string VMovementId { get; set; } = null!;

    public string VProductId { get; set; } = null!;

    public string VWarehouseId { get; set; } = null!;

    public float? RStockMax { get; set; }

    public float? RStockMin { get; set; }

    public int? IMovementTypeId { get; set; }

    public float? RQuantity { get; set; }

    public float? RPrice { get; set; }

    public float? RSubTotal { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Movement VMovement { get; set; } = null!;

    public virtual Product VProduct { get; set; } = null!;

    public virtual Warehouse VWarehouse { get; set; } = null!;
}
