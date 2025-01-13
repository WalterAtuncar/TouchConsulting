using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Deploymentfile
{
    public int IDeploymentFileId { get; set; }

    public string? VFileName { get; set; }

    public byte[]? BFileData { get; set; }

    public string? VDescription { get; set; }

    public int? ISoftwareComponentId { get; set; }

    public string? VTargetSoftwareComponentVersion { get; set; }

    public string? VPackageFiles { get; set; }

    public float? RPackageSizeKb { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Softwarecomponentrelease> Softwarecomponentreleases { get; set; } = new List<Softwarecomponentrelease>();
}
