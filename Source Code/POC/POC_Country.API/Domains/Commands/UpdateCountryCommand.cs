using MediatR;
using POC_Country.API.Models;

namespace POC_Country.API.Domains.Commands
{
    public class UpdateCountryCommand : IRequest<short>
    {
        public Country _country;

        public UpdateCountryCommand(Country country)
        {
            _country=country;
        }
    }
}
