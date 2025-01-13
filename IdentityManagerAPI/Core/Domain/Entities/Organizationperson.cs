using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Organizationperson
{
    public string VOrganizationPersonId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VOrganizationId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }
}
