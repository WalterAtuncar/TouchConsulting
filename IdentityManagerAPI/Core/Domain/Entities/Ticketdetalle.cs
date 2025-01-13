using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Ticketdetalle
{
    public string VTicketDetalleId { get; set; } = null!;

    public string? VTicketId { get; set; }

    public string? VDescripcion { get; set; }

    public string? VIdProductoDetalle { get; set; }

    public string? VCodInterno { get; set; }

    public decimal? DCantidad { get; set; }

    public decimal? DPrecioVenta { get; set; }

    public decimal? DSaldoPaciente { get; set; }

    public decimal? DSaldoAseguradora { get; set; }

    public int? IEsDespachado { get; set; }

    public string? VIdUnidadProductiva { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Ticket? VTicket { get; set; }
}
