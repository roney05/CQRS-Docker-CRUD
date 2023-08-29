using MediatR;
using POC_Country.API.Domains.Commands;
using POC_Country.API.Infrastructure.Repositories.Commands;
using POC_Country.API.Models;

namespace POC_Country.API.Handlers.CommandHandlers
{
    public class CreateCountryHandler : IRequestHandler<CreateCountryCommand, Country>
    {
        private readonly ICountryCommandRepository CountryCommandRepository;

        public CreateCountryHandler(ICountryCommandRepository countryCommandRepository)
        {
            CountryCommandRepository = countryCommandRepository;
        }
        public async Task<Country> Handle(CreateCountryCommand command, CancellationToken cancellationToken)
        {
            return await CountryCommandRepository.Add(command._country);
        }

    }
}
