using System;
using System.Collections.Generic;

namespace POC.API.Models;

public partial class Bank
{
    public int BankId { get; set; }
    public string BankName { get; set; } = null!;
    public string? BankShortName { get; set; }
    public string? BankAddress { get; set; }
    public string? BankType { get; set; }
    public short? CountryId { get; set; }
    public string AuthStatus { get; set; } = null!;
    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string LastAction { get; set; } = null!;
    public string? Ipaddress { get; set; }
    public string? Macaddress { get; set; }
    public virtual Country? Country { get; set; }
}
