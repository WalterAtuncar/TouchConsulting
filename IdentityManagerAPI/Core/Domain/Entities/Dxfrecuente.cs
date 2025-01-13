using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Dxfrecuente
{
    public string VDxFrecuenteId { get; set; } = null!;

    public string? VDiseasesId { get; set; }

    public string? VCie10id { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Dxfrecuentedetalle> Dxfrecuentedetalles { get; set; } = new List<Dxfrecuentedetalle>();

    public virtual Cie10? VCie10 { get; set; }

    public virtual Disease? VDiseases { get; set; }
}
