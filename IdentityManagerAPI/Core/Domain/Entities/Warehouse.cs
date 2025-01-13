using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Warehouse
{
    public string VWarehouseId { get; set; } = null!;

    public string? VOrganizationId { get; set; }

    public string? VLocationId { get; set; }

    public string? VName { get; set; }

    public string? VAdditionalInformation { get; set; }

    public int? ICostCenterId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Movementdetail> Movementdetails { get; set; } = new List<Movementdetail>();

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public virtual ICollection<Nodeorganizationlocationwarehouseprofile> Nodeorganizationlocationwarehouseprofiles { get; set; } = new List<Nodeorganizationlocationwarehouseprofile>();

    public virtual ICollection<Productwarehouse> Productwarehouses { get; set; } = new List<Productwarehouse>();

    public virtual ICollection<Restrictedwarehouseprofile> Restrictedwarehouseprofiles { get; set; } = new List<Restrictedwarehouseprofile>();

    public virtual Location? VLocation { get; set; }

    public virtual Organization? VOrganization { get; set; }
}
