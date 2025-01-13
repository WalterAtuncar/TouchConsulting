using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class History
{
    public string VHistoryId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public DateOnly? DStartDate { get; set; }

    public DateOnly? DEndDate { get; set; }

    public string? VOrganization { get; set; }

    public string? VTypeActivity { get; set; }

    public int? IGeografixcaHeight { get; set; }

    public string? VWorkstation { get; set; }

    public byte[]? BRubricImage { get; set; }

    public byte[]? BFingerPrintImage { get; set; }

    public string? TRubricImageText { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? ITypeOperationId { get; set; }

    public int? ITrabajoActual { get; set; }

    public string? VFechaUltimaMamo { get; set; }

    public string? VFechaUltimoPap { get; set; }

    public string? VResultadoMamo { get; set; }

    public string? VResultadosPap { get; set; }

    public int? ISoloAnio { get; set; }

    public string? VActividadEmpresa { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Typeofeep> Typeofeeps { get; set; } = new List<Typeofeep>();

    public virtual Person? VPerson { get; set; }

    public virtual ICollection<Workstationdanger> Workstationdangers { get; set; } = new List<Workstationdanger>();
}
