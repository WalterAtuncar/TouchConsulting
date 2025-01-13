using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Componentfield
{
    public string VComponentFieldId { get; set; } = null!;

    public string? VTextLabel { get; set; }

    public int? ILabelWidth { get; set; }

    public string? VAbbreviation { get; set; }

    public string? VDefaultText { get; set; }

    public int? IControlId { get; set; }

    public int? IGroupId { get; set; }

    public int? IItemId { get; set; }

    public int? IWidthControl { get; set; }

    public int? IHeightControl { get; set; }

    public int? IMaxLenght { get; set; }

    public int? IIsRequired { get; set; }

    public int? IIsCalculate { get; set; }

    public string? VFormula { get; set; }

    public int? IOrder { get; set; }

    public int? IMeasurementUnitId { get; set; }

    public float? RValidateValue1 { get; set; }

    public float? RValidateValue2 { get; set; }

    public int? IColumn { get; set; }

    public int? IDefaultIndex { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? INroDecimales { get; set; }

    public int? IReadOnly { get; set; }

    public int? IEnabled { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Componentfield1> Componentfield1s { get; set; } = new List<Componentfield1>();

    public virtual ICollection<Componentfieldvalue> Componentfieldvalues { get; set; } = new List<Componentfieldvalue>();
}
