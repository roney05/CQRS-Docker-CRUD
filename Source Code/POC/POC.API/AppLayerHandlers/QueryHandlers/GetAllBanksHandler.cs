using MediatR;
using POC.API.DomainLayer.Queries;
using POC.API.InfrastructureLayer.Repositories.Queries;
using POC.API.Models;

namespace POC.API.Services.QueryHandlers
{
    public class GetAllBanksHandler : IRequestHandler<GetAllBanksQuery, IEnumerable<Bank>>
    {
        private readonly IBankQueryRepository BankQueryRepository;

        public GetAllBanksHandler(IBankQueryRepository bankQueryRepository)
        {
            BankQueryRepository = bankQueryRepository;
        }

        public async Task<IEnumerable<Bank>> Handle(GetAllBanksQuery query, CancellationToken cancellationToken)
        {
            return (IEnumerable<Bank>)await BankQueryRepository.GetAll();
        }


    }
}
