using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Node
{
    public int INodeId { get; set; }

    public string? VDescription { get; set; }

    public string? VGeografyLocationId { get; set; }

    public string? VGeografyLocationDescription { get; set; }

    public int? INodeTypeId { get; set; }

    public DateOnly? DBeginDate { get; set; }

    public DateOnly? DEndDate { get; set; }

    public string? VPharmacyWarehouseId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Attentioninarea> Attentioninareas { get; set; } = new List<Attentioninarea>();

    public virtual ICollection<Nodeorganizationlocationprofile> Nodeorganizationlocationprofiles { get; set; } = new List<Nodeorganizationlocationprofile>();

    public virtual ICollection<Nodeorganizationlocationwarehouseprofile> Nodeorganizationlocationwarehouseprofiles { get; set; } = new List<Nodeorganizationlocationwarehouseprofile>();

    public virtual ICollection<Nodeorganizationprofile> Nodeorganizationprofiles { get; set; } = new List<Nodeorganizationprofile>();

    public virtual ICollection<Nodeserviceprofile> Nodeserviceprofiles { get; set; } = new List<Nodeserviceprofile>();

    public virtual ICollection<Rolenode> Rolenodes { get; set; } = new List<Rolenode>();
}
