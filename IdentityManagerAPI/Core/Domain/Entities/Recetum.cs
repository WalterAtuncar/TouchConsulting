using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Recetum
{
    public int IIdReceta { get; set; }

    public string? VDiagnosticRepositoryId { get; set; }

    public decimal? DCantidad { get; set; }

    public string? VPosologia { get; set; }

    public string? VDuracion { get; set; }

    public DateTime? TFechaFin { get; set; }

    public string? VIdProductoDetalle { get; set; }

    public string? VLote { get; set; }

    public int? IIdAlmacen { get; set; }

    public int? ILleva { get; set; }

    public int? INoLleva { get; set; }

    public string? VIdVentaPaciente { get; set; }

    public string? VIdVentaAseguradora { get; set; }

    public string? VIdUnidadProductiva { get; set; }

    public decimal? DSaldoPaciente { get; set; }

    public decimal? DSaldoAseguradora { get; set; }

    public string? VServiceId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public string? VComprobante { get; set; }

    public int? VMedicoTratante { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IPayMedic { get; set; }

    public int? IIsDeleted { get; set; }
}
