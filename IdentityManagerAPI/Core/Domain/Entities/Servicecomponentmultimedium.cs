using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Servicecomponentmultimedium
{
    public string VServiceComponentMultimediaId { get; set; } = null!;

    public string VServiceComponentId { get; set; } = null!;

    public string VMultimediaFileId { get; set; } = null!;

    public string? VComment { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Multimediafile VMultimediaFile { get; set; } = null!;

    public virtual Servicecomponent VServiceComponent { get; set; } = null!;
}
