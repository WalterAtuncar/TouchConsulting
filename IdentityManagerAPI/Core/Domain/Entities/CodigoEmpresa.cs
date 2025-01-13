using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class CodigoEmpresa
{
    public string VCodigoEmpresaId { get; set; } = null!;

    public string? VCiiuid { get; set; }

    public string? VName { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }
}
