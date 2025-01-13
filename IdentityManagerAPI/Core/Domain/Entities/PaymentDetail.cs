using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class PaymentDetail
{
    public string VPaymentDetailId { get; set; } = null!;

    public string? VPaymentId { get; set; }

    public string? VComponentId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
