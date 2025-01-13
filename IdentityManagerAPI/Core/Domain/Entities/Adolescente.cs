using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Adolescente
{
    public string VAdolescenteId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VEdadInicioTrabajo { get; set; }

    public string? VTipoTrabajo { get; set; }

    public string? VNroHorasTv { get; set; }

    public string? VNroHorasJuegos { get; set; }

    public string? VMenarquiaEspermarquia { get; set; }

    public string? VEdadInicioRs { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VNombreCuidador { get; set; }

    public string? VEdadCuidador { get; set; }

    public string? VDniCuidador { get; set; }

    public string? VViveCon { get; set; }

    public string? VObservaciones { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Person? VPerson { get; set; }
}
