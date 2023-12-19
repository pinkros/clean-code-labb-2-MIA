using Books.DataAccess.Repositories.Orders.DataAccess.Models.Interfaces;
using Domain.Common.Interfaces.DataAccess;
using MongoDB.Bson;

namespace Orders.DataAccess.Repositories.Interfaces;

public interface IOrderRepository : IGenericRepository<IOrderEntity, ObjectId>
{
    
}