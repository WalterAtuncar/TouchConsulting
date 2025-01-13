using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Protocolcomponent
{
    public string VProtocolComponentId { get; set; } = null!;

    public string? VProtocolId { get; set; }

    public string? VComponentId { get; set; }

    public float? RPrice { get; set; }

    public int? IOperatorId { get; set; }

    public int? IAge { get; set; }

    public int? IGenderId { get; set; }

    public int? IGrupoEtarioId { get; set; }

    public int? IIsConditionalId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IIsConditionalImc { get; set; }

    public decimal? RImc { get; set; }

    public int? IIsAdditional { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Component? VComponent { get; set; }

    public virtual Protocol? VProtocol { get; set; }
}
