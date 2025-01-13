using System;
using System.Collections.Generic;

namespace IdentityManager;

public partial class Authorizedperson
{
    public string VAuthorizedPersonId { get; set; } = null!;

    public string? VFirstName { get; set; }

    public string? VFirstLastName { get; set; }

    public string? VSecondLastName { get; set; }

    public int? IDocTypeId { get; set; }

    public string? VDocTypeName { get; set; }

    public string? VDocNumber { get; set; }

    public int? ISexTypeId { get; set; }

    public string? VSexTypeName { get; set; }

    public DateTime? DBirthDate { get; set; }

    public string? VOccupationName { get; set; }

    public string? VOrganitationName { get; set; }

    public DateTime? DEntryToMedicalCenter { get; set; }

    public string? VProtocolId { get; set; }

    public string? VProtocolName { get; set; }

    public int? IInsertUserId { get; set; }

    public DateTime? DInsertDate { get; set; }

    public int? IUpdateUserId { get; set; }

    public DateTime? DUpdateDate { get; set; }
}
