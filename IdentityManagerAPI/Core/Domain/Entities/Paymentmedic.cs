using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Paymentmedic
{
    public int IPaymetId { get; set; }

    public int? ICategoryId { get; set; }

    public int? ITypePay { get; set; }

    public int? IUserId { get; set; }

    public float? RPayPercentage { get; set; }

    public float? RQuotaMonth { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
