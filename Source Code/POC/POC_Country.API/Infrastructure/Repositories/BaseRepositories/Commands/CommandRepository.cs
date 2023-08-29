using Microsoft.EntityFrameworkCore;
using POC_Country.API.Models;

namespace POC_Country.API.Infrastructure.Repositories.BaseRepositories.Commands
{
    public class CommandRepository<T> : ICommandRepository<T> where T : class
    {
        protected readonly PocdbContext _context;

        public CommandRepository(PocdbContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            var result= await _context.SaveChangesAsync();
            return result;
        }

        public async Task<int> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            var result = await _context.SaveChangesAsync();
            return result;
        }
        
    }
}
