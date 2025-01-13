using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Hospitalizacionhabitacion
{
    public string VHospitalizacionHabitacionId { get; set; } = null!;

    public string? VHopitalizacionId { get; set; }

    public int? IHabitacionId { get; set; }

    public DateTime? DStartDate { get; set; }

    public DateTime? DEndDate { get; set; }

    public decimal? DPrecio { get; set; }

    public int? IConCargoA { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public decimal? DSaldoPaciente { get; set; }

    public decimal? DSaldoAseguradora { get; set; }

    public string? VComentaryUpdate { get; set; }

    public int? IEstateRoom { get; set; }
}
