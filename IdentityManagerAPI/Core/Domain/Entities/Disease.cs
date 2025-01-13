using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Disease
{
    public string VDiseasesId { get; set; } = null!;

    public string? VCie10id { get; set; }

    public string? VName { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Componentfieldvalue> Componentfieldvalues { get; set; } = new List<Componentfieldvalue>();

    public virtual ICollection<Diagnosticrepository> Diagnosticrepositories { get; set; } = new List<Diagnosticrepository>();

    public virtual ICollection<Dxfrecuente> Dxfrecuentes { get; set; } = new List<Dxfrecuente>();

    public virtual ICollection<Familymedicalantecedent> Familymedicalantecedents { get; set; } = new List<Familymedicalantecedent>();

    public virtual ICollection<Personmedicalhistory> Personmedicalhistories { get; set; } = new List<Personmedicalhistory>();

    public virtual ICollection<Planvigilanciadisease> Planvigilanciadiseases { get; set; } = new List<Planvigilanciadisease>();

    public virtual Cie10? VCie10 { get; set; }
}
