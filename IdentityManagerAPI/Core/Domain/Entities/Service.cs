using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Service
{
    public string VServiceId { get; set; } = null!;

    public string? VProtocolId { get; set; }

    public string? VPersonId { get; set; }

    public int? IMasterServiceId { get; set; }

    public int? IServiceStatusId { get; set; }

    public string? VMotive { get; set; }

    public int? IAptitudeStatusId { get; set; }

    public DateTime? DServiceDate { get; set; }

    public DateTime? DGlobalExpirationDate { get; set; }

    public DateTime? DObsExpirationDate { get; set; }

    public int? IFlagAgentId { get; set; }

    public string? VOrganizationId { get; set; }

    public string? VLocationId { get; set; }

    public string? VMainSymptom { get; set; }

    public int? ITimeOfDisease { get; set; }

    public int? ITimeOfDiseaseTypeId { get; set; }

    public string? VStory { get; set; }

    public int? IDreamId { get; set; }

    public int? IUrineId { get; set; }

    public int? IDepositionId { get; set; }

    public int? IAppetiteId { get; set; }

    public int? IThirstId { get; set; }

    public DateOnly? DFur { get; set; }

    public string? VCatemenialRegime { get; set; }

    public int? IMacId { get; set; }

    public int? IIsNewControl { get; set; }

    public int? IHasMedicalBreakId { get; set; }

    public DateTime? DMedicalBreakStartDate { get; set; }

    public DateTime? DMedicalBreakEndDate { get; set; }

    public string? VGeneralRecomendations { get; set; }

    public int? IDestinationMedicationId { get; set; }

    public int? ITransportMedicationId { get; set; }

    public DateTime? DStartDateRestriction { get; set; }

    public DateTime? DEndDateRestriction { get; set; }

    public int? IHasRestrictionId { get; set; }

    public int? IHasSymptomId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public DateOnly? DNextAppointment { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public int? ISendToTracking { get; set; }

    public int? IInsertUserMedicalAnalystId { get; set; }

    public int? IUpdateUserMedicalAnalystId { get; set; }

    public DateTime? DInsertDateMedicalAnalyst { get; set; }

    public DateTime? DUpdateDateMedicalAnalyst { get; set; }

    public int? IInsertUserOccupationalMedicalId { get; set; }

    public int? IUpdateUserOccupationalMedicaltId { get; set; }

    public DateTime? DInsertDateOccupationalMedical { get; set; }

    public DateTime? DUpdateDateOccupationalMedical { get; set; }

    public int? IHazInterconsultationId { get; set; }

    public string? VGestapara { get; set; }

    public string? VMenarquia { get; set; }

    public DateTime? DPap { get; set; }

    public DateTime? DMamografia { get; set; }

    public string? VCiruGine { get; set; }

    public string? VFindings { get; set; }

    public int? IStatusLiquidation { get; set; }

    public int? IServiceTypeOfInsurance { get; set; }

    public int? IModalityOfInsurance { get; set; }

    public int? IIsFac { get; set; }

    public int? IInicioEnf { get; set; }

    public int? ICursoEnf { get; set; }

    public int? IEvolucion { get; set; }

    public string? VExaAuxResult { get; set; }

    public string? VObsStatusService { get; set; }

    public DateTime? DFechaEntrega { get; set; }

    public string? VAreaId { get; set; }

    public string? VFechaUltimoPap { get; set; }

    public string? VResultadosPap { get; set; }

    public string? VFechaUltimaMamo { get; set; }

    public string? VResultadoMamo { get; set; }

    public int? IEnvioCertificado { get; set; }

    public int? IEnvioHistoria { get; set; }

    public string? VIdVentaCliente { get; set; }

    public string? VIdVentaAseguradora { get; set; }

    public string? VInicioVidaSexaul { get; set; }

    public string? VNroParejasActuales { get; set; }

    public string? VNroAbortos { get; set; }

    public string? VPrecisarCausas { get; set; }

    public int? IMedicoTratanteId { get; set; }

    public int? ITipoPago { get; set; }

    public decimal? RCostoAtencion { get; set; }

    public decimal? RCostoMedico { get; set; }

    public int? IMedicoPagado { get; set; }

    public string? VCentrocosto { get; set; }

    public string? VNroLiquidacion { get; set; }

    public int? IIsControl { get; set; }

    public int? IIsRevisedHistoryId { get; set; }

    public int? IStatusVigilanciaId { get; set; }

    public string? VNroCartaSolicitud { get; set; }

    public string? VComentaryUpdate { get; set; }

    public int? IPlanId { get; set; }

    public int? IAptitudesStatusIdFirst { get; set; }

    public string? VCommentAptitusStatusFirst { get; set; }

    public string? VComprobantePago { get; set; }

    public int? IServiceUserId { get; set; }

    public string? VArea { get; set; }

    public string? VComprobantePagoAnulado { get; set; }

    public int? ITramaCargada { get; set; }

    public string? VPuesto { get; set; }

    public string? VCargo { get; set; }

    public virtual ICollection<Auxiliaryexam> Auxiliaryexams { get; set; } = new List<Auxiliaryexam>();

    public virtual ICollection<Calendar> Calendars { get; set; } = new List<Calendar>();

    public virtual ICollection<Diagnosticrepository> Diagnosticrepositories { get; set; } = new List<Diagnosticrepository>();

    public virtual ICollection<Medication> Medications { get; set; } = new List<Medication>();

    public virtual ICollection<Procedurebyservice> Procedurebyservices { get; set; } = new List<Procedurebyservice>();

    public virtual ICollection<Recommendation> Recommendations { get; set; } = new List<Recommendation>();

    public virtual ICollection<Restriction> Restrictions { get; set; } = new List<Restriction>();

    public virtual ICollection<Servicecomponent> Servicecomponents { get; set; } = new List<Servicecomponent>();

    public virtual ICollection<Servicemultimedium> Servicemultimedia { get; set; } = new List<Servicemultimedium>();

    public virtual Person? VPerson { get; set; }

    public virtual Protocol? VProtocol { get; set; }

    public virtual ICollection<Vigilanciaservice> Vigilanciaservices { get; set; } = new List<Vigilanciaservice>();
}
