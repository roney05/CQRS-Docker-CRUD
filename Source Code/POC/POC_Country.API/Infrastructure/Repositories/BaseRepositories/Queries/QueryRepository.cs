using Microsoft.EntityFrameworkCore;
using POC_Country.API.Models;

namespace POC_Country.API.Infrastructure.Repositories.BaseRepositories.Queries
{
    public class QueryRepository<T> : IQueryRepository<T> where T : class
    {
        protected readonly PocdbContext _context;

        public QueryRepository(PocdbContext context)
        {
            _context = context;
        }
        public async Task<T> GetById(short id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
