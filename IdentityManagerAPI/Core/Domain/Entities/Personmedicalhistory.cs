using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Personmedicalhistory
{
    public string VPersonMedicalHistoryId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VDiseasesId { get; set; }

    public int? ITypeDiagnosticId { get; set; }

    public DateOnly? DStartDate { get; set; }

    public string? VDiagnosticDetail { get; set; }

    public string? VTreatmentSite { get; set; }

    public int? IAnswerId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? ISoloAnio { get; set; }

    public string? NombreHospital { get; set; }

    public string? VComplicaciones { get; set; }

    public string? VComentaryUpdate { get; set; }

    public string? VTratamiento { get; set; }

    public string? VComentarios { get; set; }

    public virtual Disease? VDiseases { get; set; }

    public virtual Person? VPerson { get; set; }
}
