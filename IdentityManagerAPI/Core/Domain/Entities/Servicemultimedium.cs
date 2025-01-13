using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Servicemultimedium
{
    public string VServiceMultimediaId { get; set; } = null!;

    public string VServiceId { get; set; } = null!;

    public string VMultimediaFileId { get; set; } = null!;

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Multimediafile VMultimediaFile { get; set; } = null!;

    public virtual Service VService { get; set; } = null!;
}
