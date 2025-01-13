using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class AntecedenteAsistencial
{
    public string VAntecendenteAsistencialId { get; set; } = null!;

    public string VPersonId { get; set; } = null!;

    public int IGrupoEtario { get; set; }

    public int IGrupoData { get; set; }

    public int IParametroId { get; set; }

    public int? IValor { get; set; }

    public int? IQuien { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }
}
