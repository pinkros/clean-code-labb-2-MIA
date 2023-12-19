using Books.DataAccess.Models.Interfaces;
using MongoDB.Bson;

namespace Books.DataAccess.Models;

public class BookModel : IBookModel
{
    public ObjectId Id { get; }
    public string Name { get; init; }
    public string Author { get; init; }
}
