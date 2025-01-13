using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Hospitalizacion
{
    public string VHopitalizacionId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public DateTime? DFechaIngreso { get; set; }

    public DateTime? DFechaAlta { get; set; }

    public string? VComentario { get; set; }

    public string? VNroLiquidacion { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public decimal? DPagoMedico { get; set; }

    public int? IMedicoPago { get; set; }

    public decimal? DPagoPaciente { get; set; }

    public int? IPacientePago { get; set; }

    public string? VComentaryUpdate { get; set; }

    public string? VDiseasesName { get; set; }

    public string? VCie10id { get; set; }

    public virtual ICollection<Hospitalizacionservice> Hospitalizacionservices { get; set; } = new List<Hospitalizacionservice>();
}
