using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Componentfield1
{
    public string VComponentId { get; set; } = null!;

    public string VComponentFieldId { get; set; } = null!;

    public string? VGroup { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Diagnosticrepository> Diagnosticrepositories { get; set; } = new List<Diagnosticrepository>();

    public virtual ICollection<Servicecomponentfield> Servicecomponentfields { get; set; } = new List<Servicecomponentfield>();

    public virtual Component VComponent { get; set; } = null!;

    public virtual Componentfield VComponentField { get; set; } = null!;
}
