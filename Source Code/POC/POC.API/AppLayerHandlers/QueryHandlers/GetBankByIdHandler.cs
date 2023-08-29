using MediatR;
using POC.API.DomainLayer.Queries;
using POC.API.InfrastructureLayer.Repositories.Queries;
using POC.API.Models;

namespace POC.API.Services.QueryHandlers
{
    public class GetBankByIdHandler : IRequestHandler<GetBankByIdQuery, Bank>
    {
        private readonly IBankQueryRepository BankQueryRepository;

        public GetBankByIdHandler(IBankQueryRepository bankQueryRepository)
        {
            BankQueryRepository = bankQueryRepository;
        }

        public async Task<Bank> Handle(GetBankByIdQuery query, CancellationToken cancellationToken)
        {
            return await BankQueryRepository.GetById(query.BankId);
        }
    }
}
