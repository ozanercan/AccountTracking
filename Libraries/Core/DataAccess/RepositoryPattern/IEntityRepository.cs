using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.DataAccess.RepositoryPattern
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> exp);
        Task<TEntity> GetNoTrackingAsync(Expression<Func<TEntity, bool>> exp);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> exp = null);
        Task<List<TEntity>> GetAllNoTrackingAsync(Expression<Func<TEntity, bool>> exp = null);

        Task<bool> AddAsync(TEntity entity);
        Task<bool> AddBulkAsync(List<TEntity> entities);
        Task<bool> UpdateAsync(TEntity entity);
        Task<bool> HardDeleteAsync(TEntity entity);
    }
}
