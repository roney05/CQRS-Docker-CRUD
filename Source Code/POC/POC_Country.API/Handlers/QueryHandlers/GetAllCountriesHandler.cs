using MediatR;
using POC_Country.API.Domains.Queries;
using POC_Country.API.Infrastructure.Repositories.Queries;
using POC_Country.API.Models;

namespace POC_Country.API.Handlers.QueryHandlers
{
    public class GetAllCountriesHandler : IRequestHandler<GetAllCountriesQuery, IEnumerable<Country>>
    {
        private readonly ICountryQueryRepository CountryQueryRepository;

        public GetAllCountriesHandler(ICountryQueryRepository countryQueryRepository)
        {
            CountryQueryRepository = countryQueryRepository;
        }

        public async Task<IEnumerable<Country>> Handle(GetAllCountriesQuery query, CancellationToken cancellationToken)
        {
            return (IEnumerable<Country>)await CountryQueryRepository.GetAll();
        }


    }
}
