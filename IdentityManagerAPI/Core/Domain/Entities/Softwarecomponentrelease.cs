using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Softwarecomponentrelease
{
    public int ISoftwareComponentId { get; set; }

    public string VSoftwareComponentVersion { get; set; } = null!;

    public int? IDeploymentFileId { get; set; }

    public DateTime? DReleaseDate { get; set; }

    public string? VDatabaseVersionRequired { get; set; }

    public string? VReleaseNotes { get; set; }

    public string? VAdditionalInformation1 { get; set; }

    public string? VAdditionalInformation2 { get; set; }

    public int? IIsPublished { get; set; }

    public int? IIsLastVersion { get; set; }

    public DateTime? DInsertDate { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Deploymentfile? IDeploymentFile { get; set; }
}
