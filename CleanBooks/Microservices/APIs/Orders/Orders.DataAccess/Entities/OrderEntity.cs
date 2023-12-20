using Books.DataAccess.Repositories.Orders.DataAccess.Models.Interfaces;
using Domain.Common.Interfaces.DataAccess;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Books.DataAccess.Repositories.Orders.DataAccess.Models;

public class OrderEntity : IOrderEntity
{
    [BsonId]
    public ObjectId Id { get; init; }

    [BsonElement]
    public string UserId { get; set; }

    [BsonElement]
    public ICollection<string> Books { get; set; }
}