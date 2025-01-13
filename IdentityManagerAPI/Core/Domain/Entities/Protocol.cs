using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Protocol
{
    public string VProtocolId { get; set; } = null!;

    public string? VName { get; set; }

    public string? VEmployerOrganizationId { get; set; }

    public string? VEmployerLocationId { get; set; }

    public int? IEsoTypeId { get; set; }

    public string? VGroupOccupationId { get; set; }

    public string? VCustomerOrganizationId { get; set; }

    public string? VCustomerLocationId { get; set; }

    public string? VNombreVendedor { get; set; }

    public string? VWorkingOrganizationId { get; set; }

    public string? VWorkingLocationId { get; set; }

    public string? VCostCenter { get; set; }

    public int? IMasterServiceTypeId { get; set; }

    public int? IMasterServiceId { get; set; }

    public int? IHasVigency { get; set; }

    public int? IValidInDays { get; set; }

    public int? IIsActive { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VAseguradoraOrganizationId { get; set; }

    public string? VComentaryUpdate { get; set; }

    public double? RPriceFactor { get; set; }

    public double? RMedicineDiscount { get; set; }

    public double? RHospitalBedPrice { get; set; }

    public double? RClinicDiscount { get; set; }

    public double? RDiscountExam { get; set; }

    public int? IConsultorio { get; set; }

    public string? VProcedencia { get; set; }

    public decimal? DPrecioConsulta { get; set; }

    public decimal? DDescuentoLaboratorio { get; set; }

    public decimal? DDescuentoRayosX { get; set; }

    public decimal? DDescuentoEcografias { get; set; }

    public decimal? DDescuentoFarmacia { get; set; }

    public decimal? DDescuentoOdontologia { get; set; }

    public decimal? DCamaHosp { get; set; }

    public decimal? DSalaOperaciones { get; set; }

    public decimal? DPrecioAmbulancia { get; set; }

    public virtual ICollection<Protocolcomponent> Protocolcomponents { get; set; } = new List<Protocolcomponent>();

    public virtual ICollection<Protocolsystemuser> Protocolsystemusers { get; set; } = new List<Protocolsystemuser>();

    public virtual ICollection<Serviceorderdetail> Serviceorderdetails { get; set; } = new List<Serviceorderdetail>();

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
