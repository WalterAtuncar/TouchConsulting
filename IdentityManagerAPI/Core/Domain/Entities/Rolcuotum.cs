using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Rolcuotum
{
    public string VRolCuotaId { get; set; } = null!;

    public int? IRolId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Rolcuotadetalle> Rolcuotadetalles { get; set; } = new List<Rolcuotadetalle>();
}
