using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Hospitalizacionservice
{
    public string VHospitalizacionServiceId { get; set; } = null!;

    public string? VHopitalizacionId { get; set; }

    public string? VServiceId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Hospitalizacion? VHopitalizacion { get; set; }
}
