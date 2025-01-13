using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Systemuser
{
    public int ISystemUserId { get; set; }

    public string? VPersonId { get; set; }

    public string? VUserName { get; set; }

    public string? VPassword { get; set; }

    public string? VSecretQuestion { get; set; }

    public string? VSecretAnswer { get; set; }

    public DateTime? DExpireDate { get; set; }

    public string? VSystemUserByOrganizationId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? ISystemUserTypeId { get; set; }

    public int? IRolVentaId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Person? VPerson { get; set; }
}
