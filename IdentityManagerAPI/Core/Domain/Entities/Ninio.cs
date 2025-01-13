using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Ninio
{
    public string VNinioId { get; set; } = null!;

    public string? VPersonId { get; set; }

    public string? VNombrePadre { get; set; }

    public string? VEdadPadre { get; set; }

    public string? VDniPadre { get; set; }

    public int? ITipoAfiliacionPadre { get; set; }

    public string? VCodigoAfiliacionPadre { get; set; }

    public int? IGradoInstruccionPadre { get; set; }

    public string? VOcupacionPadre { get; set; }

    public int? IEstadoCivilIdPadre { get; set; }

    public string? VReligionPadre { get; set; }

    public string? VNombreMadre { get; set; }

    public string? VEdadMadre { get; set; }

    public string? VDniMadre { get; set; }

    public int? ITipoAfiliacionMadre { get; set; }

    public string? VCodigoAfiliacionMadre { get; set; }

    public int? IGradoInstruccionMadre { get; set; }

    public string? VOcupacionMadre { get; set; }

    public int? IEstadoCivilIdMadre1 { get; set; }

    public string? VReligionMadre { get; set; }

    public int? IIsDeleted { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }

    public string? VNombreCuidador { get; set; }

    public string? VEdadCuidador { get; set; }

    public string? VDniCuidador { get; set; }

    public string? VPatologiasGestacion { get; set; }

    public string? VNEmbarazos { get; set; }

    public string? VNApn { get; set; }

    public string? VLugarApn { get; set; }

    public string? VComplicacionesParto { get; set; }

    public string? VAtencion { get; set; }

    public string? VEdadGestacion { get; set; }

    public string? VPeso { get; set; }

    public string? VTalla { get; set; }

    public string? VPerimetroCefalico { get; set; }

    public string? VPerimetroToracico { get; set; }

    public string? VEspecificacionesNac { get; set; }

    public string? VLme { get; set; }

    public string? VMixta { get; set; }

    public string? VArtificial { get; set; }

    public string? VInicioAlimentacionComp { get; set; }

    public string? VAlergiasMedicamentos { get; set; }

    public string? VOtrosAntecedentes { get; set; }

    public string? VEspecificacionesAgua { get; set; }

    public string? VEspecificacionesDesague { get; set; }

    public string? VTiempoHospitalizacion { get; set; }

    public string? VQuienTuberculosis { get; set; }

    public int? IQuienTuberculosis { get; set; }

    public string? VQuienAsma { get; set; }

    public int? IQuienAsma { get; set; }

    public string? VQuienVih { get; set; }

    public int? IQuienVih { get; set; }

    public string? VQuienDiabetes { get; set; }

    public int? IQuienDiabetes { get; set; }

    public string? VQuienEpilepsia { get; set; }

    public int? IQuienEpilepsia { get; set; }

    public string? VQuienAlergias { get; set; }

    public int? IQuienAlergias { get; set; }

    public string? VQuienViolenciaFamiliar { get; set; }

    public int? IQuienViolenciaFamiliar { get; set; }

    public string? VQuienAlcoholismo { get; set; }

    public int? IQuienAlcoholismo { get; set; }

    public string? VQuienDrogadiccion { get; set; }

    public int? IQuienDrogadiccion { get; set; }

    public string? VQuienHeptitisB { get; set; }

    public int? IQuienHeptitisB { get; set; }

    public string? VComentaryUpdate { get; set; }

    public virtual Person? VPerson { get; set; }
}
