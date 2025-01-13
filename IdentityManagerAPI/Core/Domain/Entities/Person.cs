using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Person
{
    public string VPersonId { get; set; } = null!;

    public string? VFirstName { get; set; }

    public string? VFirstLastName { get; set; }

    public string? VSecondLastName { get; set; }

    public int? IDocTypeId { get; set; }

    public string? VDocNumber { get; set; }

    public DateOnly? DBirthdate { get; set; }

    public string? VBirthPlace { get; set; }

    public int? ISexTypeId { get; set; }

    public int? IMaritalStatusId { get; set; }

    public int? ILevelOfId { get; set; }

    public string? VTelephoneNumber { get; set; }

    public string? VAdressLocation { get; set; }

    public string? VGeografyLocationId { get; set; }

    public string? VContactName { get; set; }

    public string? VEmergencyPhone { get; set; }

    public byte[]? BPersonImage { get; set; }

    public string? VMail { get; set; }

    public int? IBloodGroupId { get; set; }

    public int? IBloodFactorId { get; set; }

    public byte[]? BFingerPrintTemplate { get; set; }

    public byte[]? BRubricImage { get; set; }

    public byte[]? BFingerPrintImage { get; set; }

    public string? TRubricImageText { get; set; }

    public string? VCurrentOccupation { get; set; }

    public int? IDepartmentId { get; set; }

    public int? IProvinceId { get; set; }

    public int? IDistrictId { get; set; }

    public int? IResidenceInWorkplaceId { get; set; }

    public string? VResidenceTimeInWorkplace { get; set; }

    public int? ITypeOfInsuranceId { get; set; }

    public int? INumberLivingChildren { get; set; }

    public int? INumberDependentChildren { get; set; }

    public int? IOccupationTypeId { get; set; }

    public string? VOwnerName { get; set; }

    public int? INumberLiveChildren { get; set; }

    public int? INumberDeadChildren { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public int? IInsertNodeId { get; set; }

    public int? IUpdateNodeId { get; set; }

    public int? IRelationship { get; set; }

    public string? VExploitedMineral { get; set; }

    public int? IAltitudeWorkId { get; set; }

    public int? IPlaceWorkId { get; set; }

    public string? VNroPoliza { get; set; }

    public decimal? VDeducible { get; set; }

    public int? INroHermanos { get; set; }

    public string? VPassword { get; set; }

    public string? VProcedencia { get; set; }

    public string? VCentroEducativo { get; set; }

    public string? VReligion { get; set; }

    public string? VNacionalidad { get; set; }

    public string? VResidenciaAnterior { get; set; }

    public string? VSubs { get; set; }

    public string? VComentaryUpdate { get; set; }

    public string? VPhoneContac { get; set; }

    public int? IMarketing { get; set; }

    public string? VProtocolId { get; set; }

    public DateTime? DExpirationDate { get; set; }

    public int? ITotalAtenciones { get; set; }

    public int? ICountAtenciones { get; set; }

    public virtual ICollection<Adolescente> Adolescentes { get; set; } = new List<Adolescente>();

    public virtual ICollection<Adultomayor> Adultomayors { get; set; } = new List<Adultomayor>();

    public virtual ICollection<Adulto> Adultos { get; set; } = new List<Adulto>();

    public virtual ICollection<Blacklistperson> Blacklistpeople { get; set; } = new List<Blacklistperson>();

    public virtual ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();

    public virtual ICollection<Embarzo> Embarzos { get; set; } = new List<Embarzo>();

    public virtual ICollection<Familymedicalantecedent> Familymedicalantecedents { get; set; } = new List<Familymedicalantecedent>();

    public virtual ICollection<History> Histories { get; set; } = new List<History>();

    public virtual ICollection<Multimediafile> Multimediafiles { get; set; } = new List<Multimediafile>();

    public virtual ICollection<Ninio> Ninios { get; set; } = new List<Ninio>();

    public virtual ICollection<Noxioushabit> Noxioushabits { get; set; } = new List<Noxioushabit>();

    public virtual Pacient? Pacient { get; set; }

    public virtual ICollection<Personmedicalhistory> Personmedicalhistories { get; set; } = new List<Personmedicalhistory>();

    public virtual Professional? Professional { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    public virtual ICollection<Systemuser> Systemusers { get; set; } = new List<Systemuser>();

    public virtual ICollection<Vigilancium> Vigilancia { get; set; } = new List<Vigilancium>();
}
