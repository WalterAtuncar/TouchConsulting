using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Ticket
{
    public string VTicketId { get; set; } = null!;

    public string? VServiceId { get; set; }

    public DateTime? DFecha { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public int? ITipoCuentaId { get; set; }

    public int? IConCargoA { get; set; }

    public int? ITicketInterno { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public string? VComprobante { get; set; }

    public virtual ICollection<Ticketdetalle> Ticketdetalles { get; set; } = new List<Ticketdetalle>();
}
