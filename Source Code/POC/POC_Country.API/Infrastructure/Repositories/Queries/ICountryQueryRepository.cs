using POC_Country.API.Infrastructure.Repositories.BaseRepositories.Queries;
using POC_Country.API.Models;

namespace POC_Country.API.Infrastructure.Repositories.Queries
{
    public interface ICountryQueryRepository : IQueryRepository<Country>
    {
    }
}
