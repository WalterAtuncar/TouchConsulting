using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Adultomayor
{
    public string VAdultoMayorId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VNombreCuidador { get; set; }

    public string? VEdadCuidador { get; set; }

    public string? VDniCuidador { get; set; }

    public string? VMedicamentoFrecuente { get; set; }

    public string? VInicioRs { get; set; }

    public string? VNroPs { get; set; }

    public string? VFechaUr { get; set; }

    public string? VRc { get; set; }

    public string? VParto { get; set; }

    public string? VPrematuro { get; set; }

    public string? VAborto { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VReaccionAlergica { get; set; }

    public string? VDescripciónAntecedentes { get; set; }

    public string? VFlujoVaginal { get; set; }

    public string? VObservacionesEmbarazo { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Person? VPerson { get; set; }
}
