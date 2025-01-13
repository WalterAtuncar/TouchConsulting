using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Product
{
    public string VProductId { get; set; } = null!;

    public int? ICategoryId { get; set; }

    public string? VName { get; set; }

    public string? VGenericName { get; set; }

    public string? VBarCode { get; set; }

    public string? VProductCode { get; set; }

    public string? VBrand { get; set; }

    public string? VModel { get; set; }

    public string? VSerialNumber { get; set; }

    public DateTime? DExpirationDate { get; set; }

    public int? IMeasurementUnitId { get; set; }

    public float? RReferentialCostPrice { get; set; }

    public float? RReferentialSalesPrice { get; set; }

    public string? VPresentation { get; set; }

    public string? VAdditionalInformation { get; set; }

    public byte[]? BImage { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual ICollection<Movementdetail> Movementdetails { get; set; } = new List<Movementdetail>();

    public virtual ICollection<Productwarehouse> Productwarehouses { get; set; } = new List<Productwarehouse>();
}
