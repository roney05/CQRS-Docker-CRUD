using MediatR;

namespace POC.API.DomainLayer.Commands
{
    public class DeleteBankCommand: IRequest<int>
    {
        public int BankId { get; set; }
    }
}
