using MediatR;
using POC.API.Models;

namespace POC.API.DomainLayer.Queries
{
    public class GetBankByIdQuery : IRequest<Bank>
    {
        public int BankId { get; set; }
    }
}
