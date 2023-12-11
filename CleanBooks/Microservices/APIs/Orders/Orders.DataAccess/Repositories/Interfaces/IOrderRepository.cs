using Books.DataAccess.Repositories.Orders.DataAccess.Models.Interfaces;
using Domain.Common.Interfaces.DataAccess;

namespace Orders.DataAccess.Repositories.Interfaces;

public interface IOrderRepository : IGenericRepository<IOrderModel, Guid>
{
    
}