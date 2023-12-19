using Domain.Common.Interfaces.DataAccess;
using MongoDB.Bson;

namespace Books.DataAccess.Repositories.Orders.DataAccess.Models.Interfaces;

public interface IOrderEntity : IEntity<ObjectId>
{
    string UserId { get; set; }
    ICollection<string> Books { get; set; }
}