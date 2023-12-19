using Domain.Common.Interfaces.DataAccess;
using MongoDB.Bson;

namespace Books.DataAccess.Models.Interfaces;

public interface IBookModel : IEntity<ObjectId>
{
    string Name { get; }
    string Author { get; }
}