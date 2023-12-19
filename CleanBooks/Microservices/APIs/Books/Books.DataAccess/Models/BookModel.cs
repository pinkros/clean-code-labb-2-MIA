using Books.DataAccess.Models.Interfaces;

namespace Books.DataAccess.Models;

public class BookModel : IBookModel
{
    public Guid Id { get; }
    public string Name { get; init; }
    public string Author { get; init; }
}
