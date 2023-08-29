using MediatR;
using POC_Country.API.Domains.Commands;
using POC_Country.API.Infrastructure.Repositories.Commands;
using POC_Country.API.Infrastructure.Repositories.Queries;

namespace POC_Country.API.Handlers.CommandHandlers
{
    public class DeleteCountryHandler : IRequestHandler<DeleteCountryCommand, short>
    {
        private readonly ICountryCommandRepository CountryCommandRepository;
        private readonly ICountryQueryRepository CountryQueryRepository;
        public DeleteCountryHandler(ICountryCommandRepository countryCommandRepository, ICountryQueryRepository countryQueryRepository)
        {
            CountryCommandRepository = countryCommandRepository;
            CountryQueryRepository = countryQueryRepository;
        }

        public async Task<short> Handle(DeleteCountryCommand command, CancellationToken cancellationToken)
        {
            var Countrys = await CountryQueryRepository.GetById(command.CountryId);
            if (Countrys == null)
                return default;
          
            await CountryCommandRepository.Delete(Countrys);
            return Countrys.CountryId;
        }
    }
}
