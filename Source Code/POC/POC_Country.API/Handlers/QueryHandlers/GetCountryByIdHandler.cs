using MediatR;
using POC_Country.API.Domains.Queries;
using POC_Country.API.Infrastructure.Repositories.Queries;
using POC_Country.API.Models;

namespace POC_Country.API.Handlers.QueryHandlers
{
    public class GetCountryByIdHandler : IRequestHandler<GetCountryByIdQuery, Country>
    {
        private readonly ICountryQueryRepository CountryQueryRepository;

        public GetCountryByIdHandler(ICountryQueryRepository countryQueryRepository)
        {
            CountryQueryRepository = countryQueryRepository;
        }

        public async Task<Country> Handle(GetCountryByIdQuery query, CancellationToken cancellationToken)
        {
            return await CountryQueryRepository.GetById(query.CountryId);
        }
    }
}
