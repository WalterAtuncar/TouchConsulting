using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Location
{
    public string VLocationId { get; set; } = null!;

    public string? VOrganizationId { get; set; }

    public string? VName { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<Groupoccupation> Groupoccupations { get; set; } = new List<Groupoccupation>();

    public virtual ICollection<Nodeorganizationlocationprofile> Nodeorganizationlocationprofiles { get; set; } = new List<Nodeorganizationlocationprofile>();

    public virtual ICollection<Nodeorganizationlocationwarehouseprofile> Nodeorganizationlocationwarehouseprofiles { get; set; } = new List<Nodeorganizationlocationwarehouseprofile>();

    public virtual Organization? VOrganization { get; set; }

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
}
