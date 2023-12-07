namespace Domain.Common.InterFaces.DataAccess;

public interface IGenericRepository<TEntity, TId> where TEntity : IEntity<TId>
{
    Task<TEntity> GetByIdAsync(TId id);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<TEntity> DeleteAsync(TEntity entity);
}