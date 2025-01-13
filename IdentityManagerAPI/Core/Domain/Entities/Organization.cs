using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Organization
{
    public string VOrganizationId { get; set; } = null!;

    public int? IOrganizationTypeId { get; set; }

    public int? ISectorTypeId { get; set; }

    public string? VSectorName { get; set; }

    public string? VSectorCodigo { get; set; }

    public string? VIdentificationNumber { get; set; }

    public string? VName { get; set; }

    public string? VAddress { get; set; }

    public string? VPhoneNumber { get; set; }

    public string? VMail { get; set; }

    public string? VContacName { get; set; }

    public string? VContacto { get; set; }

    public string? VEmailContacto { get; set; }

    public string? VObservation { get; set; }

    public int? INumberQuotasOrganization { get; set; }

    public int? INumberQuotasMen { get; set; }

    public int? INumberQuotasWomen { get; set; }

    public int? IDepartmentId { get; set; }

    public int? IProvinceId { get; set; }

    public int? IDistrictId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public byte[]? BImage { get; set; }

    public string? VContactoMedico { get; set; }

    public string? VEmailMedico { get; set; }

    public decimal? RFactor { get; set; }

    public decimal? RFactorMed { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Liquidacion> Liquidacions { get; set; } = new List<Liquidacion>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<Nodeorganizationlocationprofile> Nodeorganizationlocationprofiles { get; set; } = new List<Nodeorganizationlocationprofile>();

    public virtual ICollection<Nodeorganizationlocationwarehouseprofile> Nodeorganizationlocationwarehouseprofiles { get; set; } = new List<Nodeorganizationlocationwarehouseprofile>();

    public virtual ICollection<Nodeorganizationprofile> Nodeorganizationprofiles { get; set; } = new List<Nodeorganizationprofile>();

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
}
