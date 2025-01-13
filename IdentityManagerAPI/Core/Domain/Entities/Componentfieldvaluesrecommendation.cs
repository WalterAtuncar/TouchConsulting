using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Componentfieldvaluesrecommendation
{
    public string VComponentFieldValuesRecommendationId { get; set; } = null!;

    public string? VComponentFieldValuesId { get; set; }

    public string? VMasterRecommendationRestricctionId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Componentfieldvalue? VComponentFieldValues { get; set; }

    public virtual Masterrecommendationrestricction? VMasterRecommendationRestricction { get; set; }
}
