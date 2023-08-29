using MediatR;
using POC_Country.API.Models;

namespace POC_Country.API.Domains.Commands
{
    public class CreateCountryCommand : IRequest<Country>
    {        
        public Country _country;
        public CreateCountryCommand(Country country)
        {
            _country = country;
        }

       
    }
}
