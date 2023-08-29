using Microsoft.EntityFrameworkCore;
using POC.API.Models;

namespace POC.API.InfrastructureLayer.Repositories.BaseRepositories.Queries
{
    public class QueryRepository<T> : IQueryRepository<T> where T : class
    {
        protected readonly PocdbContext _context;

        public QueryRepository(PocdbContext context)
        {
            _context = context;
        }
        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
