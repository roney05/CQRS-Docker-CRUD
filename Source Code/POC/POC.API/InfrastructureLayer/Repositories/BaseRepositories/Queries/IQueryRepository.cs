namespace POC.API.InfrastructureLayer.Repositories.BaseRepositories.Queries
{
    public interface IQueryRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
