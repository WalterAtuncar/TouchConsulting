using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Rolcuotadetalle
{
    public string VRolCuotaDetalleId { get; set; } = null!;

    public string? VIdProducto { get; set; }

    public string? VProductoNombre { get; set; }

    public string? VRolCuotaId { get; set; }

    public int? ICuota { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Rolcuotum? VRolCuota { get; set; }
}
