using Microsoft.EntityFrameworkCore;
using MinimalBlog.IRepositories;
using MinimalBlog.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MinimalBlog.Repositories
{
    public class EntryRepository : EFBaseRepository<Entry, int>, IEntryRepository
    {
        public EntryRepository(DbContext dbContext) : base(dbContext)
        {        
        }
        public override async Task<Entry> GetByIdAsync(int id)
        {
            //Need to remove password info, or do a ViewModel for this!
            return await _dbContext.Set<Entry>().Include(x => x.Author).FirstAsync( x=> x.Id == id);
        }

        public override IQueryable<Entry> List(Expression<Func<Entry, bool>> predicate)
        {
            // Here too
            return _dbContext.Set<Entry>().Include(x => x.Author)
            .Where(predicate).OrderByDescending(x => x.Created);
        }

    }
}
