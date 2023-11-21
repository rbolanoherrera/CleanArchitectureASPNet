using InventarioApp.Abstractions.Entities;

namespace InventarioApp.Entities.Abstractions.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(TEntity entity);
        
    }
}
