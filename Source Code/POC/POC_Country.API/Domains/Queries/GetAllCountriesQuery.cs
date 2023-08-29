using MediatR;
using POC_Country.API.Models;

namespace POC_Country.API.Domains.Queries
{
    public class GetAllCountriesQuery : IRequest<IEnumerable<Country>>
    {
    }
}
