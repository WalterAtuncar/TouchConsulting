using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Additionalexam
{
    public string VAdditionalExamId { get; set; } = null!;

    public string? VServiceId { get; set; }

    public string? VPersonId { get; set; }

    public string? VProtocolId { get; set; }

    public string? VComponentId { get; set; }

    public string? VCommentary { get; set; }

    public int? IIsProcessed { get; set; }

    public int? IIsNewService { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
