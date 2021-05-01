using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.RepositoryPattern
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public EntityRepositoryBase()
        {
            if (true)
            {
                using (var context = new TContext())
                {
                    context.Database.EnsureCreated();
                }
            }
        }

        public async Task<bool> AddAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry<TEntity>(entity).State = EntityState.Added;
                return (await context.SaveChangesAsync()) > 0;
            }
        }
        public async Task<bool> HardDeleteAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry<TEntity>(entity).State = EntityState.Deleted;
                return (await context.SaveChangesAsync()) > 0;
            }
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry<TEntity>(entity).State = EntityState.Modified;
                return (await context.SaveChangesAsync()) > 0;
            }
        }

        public async Task<bool> AddBulkAsync(List<TEntity> entities)
        {
            using (var context = new TContext())
            {
                await context.AddRangeAsync(entities);
                return (await context.SaveChangesAsync()) > 0;
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> exp)
        {
            using (var context = new TContext())
            {
                return (await context.Set<TEntity>().Where(exp).SingleOrDefaultAsync());
            }
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> exp = null)
        {
            using (var context = new TContext())
            {
                return exp == null ? await context.Set<TEntity>().ToListAsync()
                    : await context.Set<TEntity>().Where(exp).ToListAsync();
            }
        }

        public async Task<TEntity> GetNoTrackingAsync(Expression<Func<TEntity, bool>> exp)
        {
            using (var context = new TContext())
            {
                return (await context.Set<TEntity>().AsNoTracking().Where(exp).SingleOrDefaultAsync());
            }
        }

        public async Task<List<TEntity>> GetAllNoTrackingAsync(Expression<Func<TEntity, bool>> exp = null)
        {
            using (var context = new TContext())
            {
                return exp == null ? await context.Set<TEntity>().AsNoTracking().ToListAsync()
                    : await context.Set<TEntity>().AsNoTracking().Where(exp).ToListAsync();
            }
        }
    }
}
