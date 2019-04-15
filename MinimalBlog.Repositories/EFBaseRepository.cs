using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MinimalBlog.Repositories
{
    public class EFBaseRepository<TEntity, TKey> where TEntity : class
    {
        protected readonly DbContext _dbContext;

        public EFBaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected DbContext DbContext
        {
            get
            {
                return _dbContext;
            }
        }

        public virtual TEntity Create(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity is null");
            }

            DbContext.Add<TEntity>(entity);
            _dbContext.SaveChanges();
            return entity;            
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity is null");
            }
            
            DbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public virtual async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public virtual IQueryable<TEntity> List(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>()
            .Where(predicate);
        }

        public IQueryable<TEntity> List()
        {
            return _dbContext.Set<TEntity>();            
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity is null");
            }

            _dbContext.Set<TEntity>().Update(entity);
        }
    }
}
