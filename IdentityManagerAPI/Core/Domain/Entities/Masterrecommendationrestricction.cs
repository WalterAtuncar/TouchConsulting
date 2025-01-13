using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Masterrecommendationrestricction
{
    public string VMasterRecommendationRestricctionId { get; set; } = null!;

    public string? VName { get; set; }

    public int? ITypifyingId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Componentfieldvaluesrecommendation> Componentfieldvaluesrecommendations { get; set; } = new List<Componentfieldvaluesrecommendation>();

    public virtual ICollection<Componentfieldvaluesrestriction> Componentfieldvaluesrestrictions { get; set; } = new List<Componentfieldvaluesrestriction>();
}
