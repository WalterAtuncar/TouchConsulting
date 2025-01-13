using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Componentfieldvalue
{
    public string VComponentFieldValuesId { get; set; } = null!;

    public string? VDiseasesId { get; set; }

    public string? VComponentFieldId { get; set; }

    public string? VAnalyzingValue1 { get; set; }

    public string? VAnalyzingValue2 { get; set; }

    public int? IOperatorId { get; set; }

    public string? VLegalStandard { get; set; }

    public int? IIsAnormal { get; set; }

    public int? IValidationMonths { get; set; }

    public int? IGenderId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Componentfieldvaluesrecommendation> Componentfieldvaluesrecommendations { get; set; } = new List<Componentfieldvaluesrecommendation>();

    public virtual ICollection<Componentfieldvaluesrestriction> Componentfieldvaluesrestrictions { get; set; } = new List<Componentfieldvaluesrestriction>();

    public virtual ICollection<Servicecomponentfieldvalue> Servicecomponentfieldvalues { get; set; } = new List<Servicecomponentfieldvalue>();

    public virtual Componentfield? VComponentField { get; set; }

    public virtual Disease? VDiseases { get; set; }
}
