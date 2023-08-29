using MediatR;
using POC.API.DomainLayer.Commands;
using POC.API.InfrastructureLayer.Repositories.Commands;
using POC.API.Models;

namespace POC.API.AppLayerHandlers.CommandHandlers
{
    public class CreateBankHandler : IRequestHandler<CreateBankCommand, Bank>
    {
        private readonly IBankCommandRepository BankCommandRepository;

        public CreateBankHandler(IBankCommandRepository bankCommandRepository)
        {
            BankCommandRepository = bankCommandRepository;
        }
        public async Task<Bank> Handle(CreateBankCommand command, CancellationToken cancellationToken)
        {
            return await BankCommandRepository.Add(command._bank);
        }

    }
}
