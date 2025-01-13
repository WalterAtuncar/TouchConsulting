using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Noxioushabit
{
    public string VNoxiousHabitsId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public int? ITypeHabitsId { get; set; }

    public string? VFrequency { get; set; }

    public string? VComment { get; set; }

    public string? VDescriptionHabit { get; set; }

    public string? VDescriptionQuantity { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Person? VPerson { get; set; }
}
