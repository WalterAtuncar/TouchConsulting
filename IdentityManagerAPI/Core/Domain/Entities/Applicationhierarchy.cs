using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Applicationhierarchy
{
    public int IApplicationHierarchyId { get; set; }

    public int? IApplicationHierarchyTypeId { get; set; }

    public int? ILevel { get; set; }

    public string? VDescription { get; set; }

    public string? VForm { get; set; }

    public string? VCode { get; set; }

    public int? IParentId { get; set; }

    public int? IScopeId { get; set; }

    public int? ITypeFormId { get; set; }

    public int? IExternalUserFunctionalityTypeId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Protocolsystemuser> Protocolsystemusers { get; set; } = new List<Protocolsystemuser>();

    public virtual ICollection<Rolenodeprofile> Rolenodeprofiles { get; set; } = new List<Rolenodeprofile>();

    public virtual ICollection<Systemusergobalprofile> Systemusergobalprofiles { get; set; } = new List<Systemusergobalprofile>();
}
