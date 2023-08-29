namespace POC_Country.API.Infrastructure.Repositories.BaseRepositories.Queries
{
    public interface IQueryRepository<T> where T : class
    {
        Task<T> GetById(short id);
        Task<IEnumerable<T>> GetAll();
    }
}
