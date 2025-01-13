using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Vigilanciaservice
{
    public string VVigilanciaServiceId { get; set; } = null!;

    public string? VVigilanciaId { get; set; }

    public string? VServiceId { get; set; }

    public string? VCommentary { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Service? VService { get; set; }

    public virtual Vigilancium? VVigilancia { get; set; }
}
