using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Multimediafile
{
    public string VMultimediaFileId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VFileName { get; set; }

    public byte[]? BFile { get; set; }

    public byte[]? BThumbnailFile { get; set; }

    public string? VComment { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<ServicecomponentfieldValuesmultimedium> ServicecomponentfieldValuesmultimedia { get; set; } = new List<ServicecomponentfieldValuesmultimedium>();

    public virtual ICollection<Servicecomponentmultimedium> Servicecomponentmultimedia { get; set; } = new List<Servicecomponentmultimedium>();

    public virtual ICollection<Servicemultimedium> Servicemultimedia { get; set; } = new List<Servicemultimedium>();

    public virtual Person? VPerson { get; set; }
}
