using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Envionatclar
{
    public string VEnvioNatclarId { get; set; } = null!;

    public string? VServiceId { get; set; }

    public string? VPaquete { get; set; }

    public int? IEstadoId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
