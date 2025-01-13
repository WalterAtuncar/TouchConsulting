using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Professional
{
    public string VPersonId { get; set; } = null!;

    public int? IProfessionId { get; set; }

    public string? VProfessionalCode { get; set; }

    public string? VProfessionalInformation { get; set; }

    public byte[]? BSignatureImage { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IUpdateNodeId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public string? VComponentId { get; set; }

    public decimal? RMonthlyPayment { get; set; }

    public TimeOnly? TMonthlyHours { get; set; }

    public DateTime? DStartDateOfWork { get; set; }

    public DateTime? DContractFrom { get; set; }

    public DateTime? DContractUntil { get; set; }

    public DateTime? DCessationDate { get; set; }

    public int? IProfesion { get; set; }

    public virtual Person VPerson { get; set; } = null!;
}
