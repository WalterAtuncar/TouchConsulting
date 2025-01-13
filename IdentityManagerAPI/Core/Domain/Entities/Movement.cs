using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Movement
{
    public string VMovementId { get; set; } = null!;

    public string? VWarehouseId { get; set; }

    public string? VSupplierId { get; set; }

    public int? IProcessTypeId { get; set; }

    public string? VParentMovementId { get; set; }

    public string? VMotive { get; set; }

    public int? IMotiveTypeId { get; set; }

    public DateTime? DDate { get; set; }

    public float? RTotalQuantity { get; set; }

    public int? IMovementTypeId { get; set; }

    public int? IRequireRemoteProcess { get; set; }

    public string? VRemoteWarehouseId { get; set; }

    public int? ICurrencyId { get; set; }

    public float? RExchangeRate { get; set; }

    public string? VReferenceDocument { get; set; }

    public int? ICostCenterId { get; set; }

    public string? VObservations { get; set; }

    public int? IIsLocallyProcessed { get; set; }

    public int? IIsRemoteProcessed { get; set; }

    public int? IInsertUserId { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IUpdateNodeId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Movementdetail> Movementdetails { get; set; } = new List<Movementdetail>();

    public virtual Supplier? VSupplier { get; set; }

    public virtual Warehouse? VWarehouse { get; set; }
}
