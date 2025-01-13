using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Component
{
    public string VComponentId { get; set; } = null!;

    public string? VName { get; set; }

    public int? ICategoryId { get; set; }

    public float? RBasePrice { get; set; }

    public int? IDiagnosableId { get; set; }

    public int? IIsApprovedId { get; set; }

    public int? IComponentTypeId { get; set; }

    public int? IUiisVisibleId { get; set; }

    public int? IUiindex { get; set; }

    public int? IValidInDays { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VIdUnidadProductiva { get; set; }

    public float? RPriceSegus { get; set; }

    public string? VCodigoSegus { get; set; }

    public int? IGroupId { get; set; }

    public int? ISubGroupId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public int? IKindOfService { get; set; }

    public int? IPriceIsRecharged { get; set; }

    public virtual ICollection<Attentioninareacomponent> Attentioninareacomponents { get; set; } = new List<Attentioninareacomponent>();

    public virtual ICollection<Auxiliaryexam> Auxiliaryexams { get; set; } = new List<Auxiliaryexam>();

    public virtual ICollection<Componentfield1> Componentfield1s { get; set; } = new List<Componentfield1>();

    public virtual ICollection<Protocolcomponent> Protocolcomponents { get; set; } = new List<Protocolcomponent>();

    public virtual ICollection<Recommendation> Recommendations { get; set; } = new List<Recommendation>();

    public virtual ICollection<Restriction> Restrictions { get; set; } = new List<Restriction>();

    public virtual ICollection<Rolenodecomponentprofile> Rolenodecomponentprofiles { get; set; } = new List<Rolenodecomponentprofile>();

    public virtual ICollection<Servicecomponent> Servicecomponents { get; set; } = new List<Servicecomponent>();
}
