using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Pacientmultimediadatum
{
    public string VPacientMultimediaDataId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Pacient? VPerson { get; set; }
}
