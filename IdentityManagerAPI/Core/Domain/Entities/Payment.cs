using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Payment
{
    public string VPaymentId { get; set; } = null!;

    public int? IUserId { get; set; }

    public int? ITypeAttention { get; set; }

    public decimal? RPaymentPercentage { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
