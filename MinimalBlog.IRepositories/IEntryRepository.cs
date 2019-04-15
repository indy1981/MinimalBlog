using MinimalBlog.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MinimalBlog.IRepositories
{
    public interface IEntryRepository 
    {
        Task<Entry> GetByIdAsync(int id);

        Entry Create(Entry entity);

        void Update(Entry entity);

        void Delete(Entry entity);

        IQueryable<Entry> List(Expression<Func<Entry, bool>> predicate);
    }
}
