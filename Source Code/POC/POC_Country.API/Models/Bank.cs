using System;
using System.Collections.Generic;

namespace POC_Country.API.Models;

public partial class Bank
{
    public int BankId { get; set; }

    public string BankName { get; set; }

    public string BankShortName { get; set; }

    public string BankAddress { get; set; }

    public string BankType { get; set; }

    public short? CountryId { get; set; }

    public string AuthStatus { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string LastAction { get; set; }

    public string Ipaddress { get; set; }

    public string Macaddress { get; set; }

    public virtual Country Country { get; set; }
}
