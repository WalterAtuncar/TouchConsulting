using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Datahierarchy
{
    public int IGroupId { get; set; }

    public int IItemId { get; set; }

    public string? VValue1 { get; set; }

    public string? VValue2 { get; set; }

    public string? VField { get; set; }

    public int? IParentItemId { get; set; }

    public int? ISort { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }
}
