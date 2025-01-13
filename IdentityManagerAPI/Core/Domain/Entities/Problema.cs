using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Problema
{
    public string VProblemaId { get; set; } = null!;

    public int? ITipo { get; set; }

    public string? VPersonId { get; set; }

    public DateTime? DFecha { get; set; }

    public string? VDescripcion { get; set; }

    public int? IEsControlado { get; set; }

    public string? VObservacion { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }
}
