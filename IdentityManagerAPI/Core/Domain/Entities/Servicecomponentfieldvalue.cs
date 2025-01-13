using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Servicecomponentfieldvalue
{
    public string VServiceComponentFieldValuesId { get; set; } = null!;

    public string? VComponentFieldValuesId { get; set; }

    public string? VServiceComponentFieldsId { get; set; }

    public string? VValue1 { get; set; }

    public string? VValue2 { get; set; }

    public int? IIndex { get; set; }

    public int? IValue1 { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<ServicecomponentfieldValuesmultimedium> ServicecomponentfieldValuesmultimedia { get; set; } = new List<ServicecomponentfieldValuesmultimedium>();

    public virtual Componentfieldvalue? VComponentFieldValues { get; set; }

    public virtual Servicecomponentfield? VServiceComponentFields { get; set; }
}
