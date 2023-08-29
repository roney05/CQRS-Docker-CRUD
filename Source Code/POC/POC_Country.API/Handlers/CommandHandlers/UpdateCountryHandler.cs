using MediatR;
using POC_Country.API.Domains.Commands;
using POC_Country.API.Infrastructure.Repositories.Commands;
using POC_Country.API.Infrastructure.Repositories.Queries;

namespace POC_Country.API.Handlers.CommandHandlers
{
    public class UpdateCountryHandler : IRequestHandler<UpdateCountryCommand, short>
    {
        private readonly ICountryCommandRepository CountryCommandRepository;
        private readonly ICountryQueryRepository CountryQueryRepository;
        public UpdateCountryHandler(ICountryCommandRepository countryCommandRepository, ICountryQueryRepository countryQueryRepository)
        {
            CountryCommandRepository = countryCommandRepository;
            CountryQueryRepository = countryQueryRepository;
        }
              
        public async Task<short> Handle(UpdateCountryCommand command, CancellationToken cancellationToken)
        {
            var Countrys = await CountryQueryRepository.GetById(command._country.CountryId);
            if (Countrys == null)
                return default;

            Countrys.CountryName = command._country.CountryName;
            Countrys.CountryShortName = command._country.CountryShortName;            
            Countrys.AuthStatus = command._country.AuthStatus;
            Countrys.CreatedBy = command._country.CreatedBy;
            Countrys.CreatedDate = command._country.CreatedDate;
            Countrys.LastModifiedBy = command._country.LastModifiedBy;
            Countrys.LastModifiedDate = command._country.LastModifiedDate;
            Countrys.LastAction = command._country.LastAction;
            Countrys.Ipaddress = command._country.Ipaddress;
            Countrys.Macaddress = command._country.Macaddress;

            await CountryCommandRepository.Update(Countrys);
            return Countrys.CountryId;
        }
    }
}
