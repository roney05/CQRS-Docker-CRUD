using System;
using System.Collections.Generic;

namespace POC.API.Models;

public partial class Country
{
    public short CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public string? CountryShortName { get; set; }

    public string AuthStatus { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string LastAction { get; set; } = null!;

    public string? Ipaddress { get; set; }

    public string? Macaddress { get; set; }

    public virtual ICollection<Bank> Banks { get; set; } = new List<Bank>();
}
