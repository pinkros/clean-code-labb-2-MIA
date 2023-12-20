using Books.DataAccess.Repositories.Orders.DataAccess.Models;
using Domain.Common.Interfaces.DataAccess;
using MongoDB.Bson;

namespace Orders.DataAccess.Repositories.Interfaces;

public interface IOrderRepository : IGenericRepository<OrderEntity, ObjectId>
{
    
}