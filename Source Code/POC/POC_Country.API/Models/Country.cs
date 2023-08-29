using System;
using System.Collections.Generic;

namespace POC_Country.API.Models;

public partial class Country
{
    public short CountryId { get; set; }

    public string CountryName { get; set; }

    public string CountryShortName { get; set; }

    public string AuthStatus { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string LastAction { get; set; }

    public string Ipaddress { get; set; }

    public string Macaddress { get; set; }

    public virtual ICollection<Bank> Banks { get; set; } = new List<Bank>();
}
