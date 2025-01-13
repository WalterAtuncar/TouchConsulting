using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Servicecomponent
{
    public string VServiceComponentId { get; set; } = null!;

    public string? VServiceId { get; set; }

    public string? VComponentId { get; set; }

    public int? IServiceComponentStatusId { get; set; }

    public int? IExternalInternalId { get; set; }

    public int? IServiceComponentTypeId { get; set; }

    public int? IIsVisibleId { get; set; }

    public int? IIsInheritedId { get; set; }

    public DateTime? DCalledDate { get; set; }

    public DateTime? DStartDate { get; set; }

    public DateTime? DEndDate { get; set; }

    public int? IIndex { get; set; }

    public float? RPrice { get; set; }

    public int? IIsInvoicedId { get; set; }

    public int? IIsRequiredId { get; set; }

    public int? IIsManuallyAddedId { get; set; }

    public int? IQueueStatusId { get; set; }

    public string? VNameOfice { get; set; }

    public string? VComment { get; set; }

    public int? IIscalling { get; set; }

    public int? IIsApprovedId { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IApprovedInsertUserId { get; set; }

    public int? IApprovedUpdateUserId { get; set; }

    public DateTime? DApprovedInsertDate { get; set; }

    public DateTime? DApprovedUpdateDate { get; set; }

    public int? IInsertUserMedicalAnalystId { get; set; }

    public int? IUpdateUserMedicalAnalystId { get; set; }

    public DateTime? DInsertDateMedicalAnalyst { get; set; }

    public DateTime? DUpdateDateMedicalAnalyst { get; set; }

    public int? IInsertUserTechnicalDataRegisterId { get; set; }

    public int? IUpdateUserTechnicalDataRegisterId { get; set; }

    public DateTime? DInsertDateTechnicalDataRegister { get; set; }

    public DateTime? DUpdateDateTechnicalDataRegister { get; set; }

    public int? IIscalling1 { get; set; }

    public int? IAuditorInsertUserId { get; set; }

    public DateTime? DAuditorInsertUser { get; set; }

    public int? IAuditorUpdateUserId { get; set; }

    public DateTime? DAuditorUpdateUser { get; set; }

    public string? VIdUnidadProductiva { get; set; }

    public decimal? DSaldoPaciente { get; set; }

    public decimal? DSaldoAseguradora { get; set; }

    public int? IMedicoTratanteId { get; set; }

    public int? ISystemUserEspecialistaId { get; set; }

    public int? IConCargoA { get; set; }

    public int? ITipoDesc { get; set; }

    public string? VComentaryUpdate { get; set; }

    public int? IUserTypeId { get; set; }

    public int? IIsFact { get; set; }

    public string? VArea { get; set; }

    public string? VCargo { get; set; }

    public int? IPayMedic { get; set; }

    public int? IApplicantMedic { get; set; }

    public decimal? ICantidad { get; set; }

    public decimal? DDescuento { get; set; }

    public virtual ICollection<Servicecomponentfield> Servicecomponentfields { get; set; } = new List<Servicecomponentfield>();

    public virtual ICollection<Servicecomponentmultimedium> Servicecomponentmultimedia { get; set; } = new List<Servicecomponentmultimedium>();

    public virtual Component? VComponent { get; set; }

    public virtual Service? VService { get; set; }
}
