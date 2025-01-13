using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Medico
{
    public string VMedicoId { get; set; } = null!;

    public int? IMasterServiceId { get; set; }

    public int? ISystemUserId { get; set; }

    public int? IMasterServiceTypeId { get; set; }

    public decimal? RClinica { get; set; }

    public decimal? RMedico { get; set; }

    public int? ICategoryId { get; set; }

    public decimal? RPrice { get; set; }

    public string? VEmployerOrganizationId { get; set; }

    public string? VCustomerOrganizationId { get; set; }

    public string? VWorkingOrganizationId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }
}
