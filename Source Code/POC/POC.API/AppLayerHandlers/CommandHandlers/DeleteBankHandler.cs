using MediatR;
using POC.API.DomainLayer.Commands;
using POC.API.InfrastructureLayer.Repositories.Commands;
using POC.API.InfrastructureLayer.Repositories.Queries;

namespace POC.API.AppLayerHandlers.CommandHandlers
{
    public class DeleteBankHandler : IRequestHandler<DeleteBankCommand, int>
    {
        private readonly IBankCommandRepository BankCommandRepository;
        private readonly IBankQueryRepository BankQueryRepository;
        public DeleteBankHandler(IBankCommandRepository bankCommandRepository, IBankQueryRepository bankQueryRepository)
        {
            BankCommandRepository = bankCommandRepository;
            BankQueryRepository = bankQueryRepository;
        }

        public async Task<int> Handle(DeleteBankCommand command, CancellationToken cancellationToken)
        {
            var Banks = await BankQueryRepository.GetById(command.BankId);
            if (Banks == null)
                return default;
          
            await BankCommandRepository.Delete(Banks);
            return Banks.BankId;
        }
    }
}
