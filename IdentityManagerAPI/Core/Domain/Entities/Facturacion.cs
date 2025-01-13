using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Facturacion
{
    public string VFacturacionId { get; set; } = null!;

    public DateOnly? DFechaRegistro { get; set; }

    public DateOnly? DFechaCobro { get; set; }

    public string? VNumeroFactura { get; set; }

    public int? IEstadoFacturacion { get; set; }

    public string? VEmpresaCliente { get; set; }

    public string? VEmpresaSede { get; set; }

    public decimal? DDetraccion { get; set; }

    public decimal? DSubTotal { get; set; }

    public decimal? DIgv { get; set; }

    public decimal? DMontoTotal { get; set; }

    public DateTime? DFechaInicio { get; set; }

    public DateTime? DFechaFin { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VDescripcion { get; set; }

    public decimal? DDescuento { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Facturaciondetalle> Facturaciondetalles { get; set; } = new List<Facturaciondetalle>();
}
