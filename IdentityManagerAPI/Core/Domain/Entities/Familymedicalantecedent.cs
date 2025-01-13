using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Familymedicalantecedent
{
    public string VFamilyMedicalAntecedentsId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VDiseasesId { get; set; }

    public int? ITypeFamilyId { get; set; }

    public string? VComment { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Disease? VDiseases { get; set; }

    public virtual Person? VPerson { get; set; }
}
