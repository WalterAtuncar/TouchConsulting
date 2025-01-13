using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Vacation
{
    public string VVacationId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public int? IIsProcessed { get; set; }

    public int? IIsDeleted { get; set; }

    public DateTime? DStartVacation { get; set; }

    public DateTime? DEndVacation { get; set; }
}
