using POC_Country.API.Infrastructure.Repositories.BaseRepositories.Commands;
using POC_Country.API.Models;

namespace POC_Country.API.Infrastructure.Repositories.Commands
{
    public class CountryCommandRepository : CommandRepository<Country>, ICountryCommandRepository
    {
        public CountryCommandRepository(PocdbContext dbContext)
           : base(dbContext)
        {


        }




    }
}
