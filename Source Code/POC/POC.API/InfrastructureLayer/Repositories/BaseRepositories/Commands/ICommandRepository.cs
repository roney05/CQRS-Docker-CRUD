namespace POC.API.InfrastructureLayer.Repositories.BaseRepositories.Commands
{
    public interface ICommandRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<int> Delete(T entity);
        Task<int> Update(T entity);
    }
}
