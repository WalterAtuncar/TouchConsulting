using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Diagnosticrepository
{
    public string VDiagnosticRepositoryId { get; set; } = null!;

    public string? VServiceId { get; set; }

    public string? VDiseasesId { get; set; }

    public string? VComponentId { get; set; }

    public string? VComponentFieldId { get; set; }

    public int? IAutoManualId { get; set; }

    public int? IPreQualificationId { get; set; }

    public int? IFinalQualificationId { get; set; }

    public int? IDiagnosticTypeId { get; set; }

    public int? IIsSentToAntecedent { get; set; }

    public DateTime? DExpirationDateDiagnostic { get; set; }

    public int? IGenerateMedicalBreak { get; set; }

    public string? VRecomendations { get; set; }

    public int? IDiagnosticSourceId { get; set; }

    public int? IShapeAccidentId { get; set; }

    public int? IBodyPartId { get; set; }

    public int? IClassificationOfWorkAccidentId { get; set; }

    public int? IRiskFactorId { get; set; }

    public int? IClassificationOfWorkdiseaseId { get; set; }

    public int? ISendToInterconsultationId { get; set; }

    public int? IInterconsultationDestinationId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VInterconsultationDestinationId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Componentfield1? Componentfield1 { get; set; }

    public virtual ICollection<Recommendation> Recommendations { get; set; } = new List<Recommendation>();

    public virtual ICollection<Restriction> Restrictions { get; set; } = new List<Restriction>();

    public virtual Disease? VDiseases { get; set; }

    public virtual Service? VService { get; set; }
}
