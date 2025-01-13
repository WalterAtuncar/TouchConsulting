using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Productsformigration
{
    public int IProductForMigrationId { get; set; }

    public string? VWarehouseId { get; set; }

    public string? VProductId { get; set; }

    public int? ICategoryId { get; set; }

    public string? VName { get; set; }

    public float? RStockMin { get; set; }

    public float? RStockMax { get; set; }

    public float? RStockActual { get; set; }

    public int? IMovementTypeId { get; set; }

    public string? VMovementType { get; set; }

    public int? IMotiveTypeId { get; set; }

    public string? VMotiveType { get; set; }

    public DateTime? DMovementDate { get; set; }

    public DateTime? DInsertDate { get; set; }

    public string? VComentaryUpdate { get; set; }
}
