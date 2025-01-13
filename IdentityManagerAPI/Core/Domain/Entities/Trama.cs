using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Trama
{
    public string VTramaId { get; set; } = null!;

    public string? VTipoRegistro { get; set; }

    public DateTime? DFechaIngreso { get; set; }

    public DateTime? DFechaAlta { get; set; }

    public int? IGenero { get; set; }

    public int? IGrupoEtario { get; set; }

    public string? VDiseasesName { get; set; }

    public string? VCie10id { get; set; }

    public int? IUps { get; set; }

    public int? IProcedimiento { get; set; }

    public int? IEspecialidad { get; set; }

    public int? ITipoParto { get; set; }

    public int? ITipoNacimiento { get; set; }

    public int? ITipoComplicacion { get; set; }

    public int? IProgramacion { get; set; }

    public int? ITipoCirugia { get; set; }

    public int? IHorasProg { get; set; }

    public int? IHorasEfect { get; set; }

    public int? IHorasActo { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public string? VServiceId { get; set; }
}
