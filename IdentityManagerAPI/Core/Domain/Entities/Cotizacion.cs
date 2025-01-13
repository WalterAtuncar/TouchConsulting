using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Cotizacion
{
    public string VCotizacionId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VProtocolId { get; set; }

    public decimal? DCostoTotal { get; set; }

    public decimal? DACuenta { get; set; }

    public decimal? DSaldo { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IProcesado { get; set; }
}
