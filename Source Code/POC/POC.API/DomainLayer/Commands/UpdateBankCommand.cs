using MediatR;
using POC.API.Models;

namespace POC.API.DomainLayer.Commands
{
    public class UpdateBankCommand : IRequest<int>
    {
        //public int BankId { get; set; }
        //public string BankName { get; set; } = null!;
        //public string? BankShortName { get; set; }
        //public string? BankAddress { get; set; }
        //public string? BankType { get; set; }
        //public short? CountryId { get; set; }
        //public string AuthStatus { get; set; } = null!;
        //public string CreatedBy { get; set; } = null!;
        //public DateTime CreatedDate { get; set; }
        //public string? LastModifiedBy { get; set; }
        //public DateTime? LastModifiedDate { get; set; }
        //public string LastAction { get; set; } = null!;
        //public string? Ipaddress { get; set; }
        //public string? Macaddress { get; set; }
        public Bank _bank;

        public UpdateBankCommand(Bank bank)
        {
            _bank=bank;
        }

        //public UpdateBankCommand(int bankId, string bankName, string bankShortName, string bankAddress, string bankType, short? countryId, string authStatus
        //        , string createdBy, DateTime createdDate, string lastModifiedBy, DateTime? lastModifiedDate, string lastAction, string ipaddress, string macaddress)
        //{
        //    BankId = bankId;
        //    BankName = bankName;
        //    BankShortName = bankShortName;
        //    BankAddress = bankAddress;
        //    BankType = bankType;
        //    CountryId = countryId;
        //    AuthStatus = authStatus;
        //    CreatedBy = createdBy;
        //    CreatedDate = createdDate;
        //    LastModifiedBy = lastModifiedBy;
        //    LastModifiedDate = lastModifiedDate;
        //    LastAction = lastAction;
        //    Ipaddress = ipaddress;
        //    Macaddress = macaddress;
        //}
    }
}
