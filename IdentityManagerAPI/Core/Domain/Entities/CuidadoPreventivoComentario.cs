using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class CuidadoPreventivoComentario
{
    public string VCuidadoPreventivoComentarioId { get; set; } = null!;

    public string VPersonId { get; set; } = null!;

    public int IGrupoId { get; set; }

    public int IParametroId { get; set; }

    public string? VComentario { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }
}
