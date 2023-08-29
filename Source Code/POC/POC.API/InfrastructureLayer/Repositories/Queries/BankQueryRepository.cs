using POC.API.InfrastructureLayer.Repositories.BaseRepositories.Queries;
using POC.API.Models;

namespace POC.API.InfrastructureLayer.Repositories.Queries
{
    public class BankQueryRepository : QueryRepository<Bank>, IBankQueryRepository
    {
        public BankQueryRepository(PocdbContext dbContext)
          : base(dbContext)
        {


        }




    }
}
