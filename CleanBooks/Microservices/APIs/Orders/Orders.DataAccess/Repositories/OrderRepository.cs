using Books.DataAccess.Repositories.Orders.DataAccess.Models.Interfaces;
using Orders.DataAccess.Repositories.Interfaces;

namespace Orders.DataAccess.Repositories;

public class OrderRepository : IOrderRepository
{
    public Task<IOrderModel> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IOrderModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(IOrderModel entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(IOrderModel entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}