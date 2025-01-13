using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Supplier
{
    public string VSupplierId { get; set; } = null!;

    public int? ISectorTypeId { get; set; }

    public string? VIdentificationNumber { get; set; }

    public string? VName { get; set; }

    public string? VAddress { get; set; }

    public string? VPhoneNumber { get; set; }

    public string? VMail { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IUpdateNodeId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();
}
