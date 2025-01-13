using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Serviceorderdetail
{
    public string VServiceOrderDetailId { get; set; } = null!;

    public string? VServiceOrderId { get; set; }

    public string? VProtocolId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public float? RProtocolPrice { get; set; }

    public int? INumberOfWorkerProtocol { get; set; }

    public float? RTotal { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Protocol? VProtocol { get; set; }

    public virtual Serviceorder? VServiceOrder { get; set; }
}
