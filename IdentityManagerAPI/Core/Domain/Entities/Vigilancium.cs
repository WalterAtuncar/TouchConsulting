using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Vigilancium
{
    public string VVigilanciaId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VPlanVigilanciaId { get; set; }

    public int? IWasNotifiedId { get; set; }

    public int? IConfirmedNotification { get; set; }

    public string? VCommentary { get; set; }

    public int? IDoctorRespondibleId { get; set; }

    public int? IStateVigilanciaId { get; set; }

    public DateTime? DStartDate { get; set; }

    public DateTime? DEndDate { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public virtual Person? VPerson { get; set; }

    public virtual Planvigilancium? VPlanVigilancia { get; set; }

    public virtual ICollection<Vigilanciaservice> Vigilanciaservices { get; set; } = new List<Vigilanciaservice>();
}
