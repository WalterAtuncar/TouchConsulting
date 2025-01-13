using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Serviceorder
{
    public string VServiceOrderId { get; set; } = null!;

    public string? VCustomServiceOrderId { get; set; }

    public string? VDescription { get; set; }

    public string? VComentary { get; set; }

    public int? INumberOfWorker { get; set; }

    public float? RTotalCost { get; set; }

    public DateTime? DDeliveryDate { get; set; }

    public int? IServiceOrderStatusId { get; set; }

    public int? ILineaCreditoId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IMostrarPrecio { get; set; }

    public int? IEsProtocoloEspecial { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Serviceorderdetail> Serviceorderdetails { get; set; } = new List<Serviceorderdetail>();
}
