namespace Domain.Common.Interfaces.DataAccess;

public interface IGenericRepository<TEntity, TId> 
{
    Task<TEntity> GetByIdAsync(TId id);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TId id);

}