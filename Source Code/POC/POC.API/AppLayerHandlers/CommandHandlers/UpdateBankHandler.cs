using MediatR;
using POC.API.DomainLayer.Commands;
using POC.API.InfrastructureLayer.Repositories.Commands;
using POC.API.InfrastructureLayer.Repositories.Queries;

namespace POC.API.AppLayerHandlers.CommandHandlers
{
    public class UpdateBankHandler : IRequestHandler<UpdateBankCommand, int>
    {
        private readonly IBankCommandRepository BankCommandRepository;
        private readonly IBankQueryRepository BankQueryRepository;
        public UpdateBankHandler(IBankCommandRepository bankCommandRepository, IBankQueryRepository bankQueryRepository)
        {
            BankCommandRepository = bankCommandRepository;
            BankQueryRepository = bankQueryRepository;
        }
              
        public async Task<int> Handle(UpdateBankCommand command, CancellationToken cancellationToken)
        {
            var Banks = await BankQueryRepository.GetById(command._bank.BankId);
            if (Banks == null)
                return default;

            Banks.BankName = command._bank.BankName;
            Banks.BankShortName = command._bank.BankShortName;
            Banks.BankAddress = command._bank.BankAddress;
            Banks.BankType = command._bank.BankType;
            Banks.CountryId = command._bank.CountryId;
            Banks.AuthStatus = command._bank.AuthStatus;
            Banks.CreatedBy = command._bank.CreatedBy;
            Banks.CreatedDate = command._bank.CreatedDate;
            Banks.LastModifiedBy = command._bank.LastModifiedBy;
            Banks.LastModifiedDate = command._bank.LastModifiedDate;
            Banks.LastAction = command._bank.LastAction;
            Banks.Ipaddress = command._bank.Ipaddress;
            Banks.Macaddress = command._bank.Macaddress;

            await BankCommandRepository.Update(Banks);
            return Banks.BankId;
        }
    }
}
