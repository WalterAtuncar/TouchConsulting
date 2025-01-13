using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Servicecomponentfield
{
    public string VServiceComponentFieldsId { get; set; } = null!;

    public string? VServiceComponentId { get; set; }

    public string? VComponentId { get; set; }

    public string? VComponentFieldId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Componentfield1? Componentfield1 { get; set; }

    public virtual ICollection<Servicecomponentfieldvalue> Servicecomponentfieldvalues { get; set; } = new List<Servicecomponentfieldvalue>();

    public virtual Servicecomponent? VServiceComponent { get; set; }
}
