using POC.API.InfrastructureLayer.Repositories.BaseRepositories.Commands;
using POC.API.Models;

namespace POC.API.InfrastructureLayer.Repositories.Commands
{
    public class BankCommandRepository : CommandRepository<Bank>, IBankCommandRepository
    {
        public BankCommandRepository(PocdbContext dbContext)
           : base(dbContext)
        {


        }




    }
}
