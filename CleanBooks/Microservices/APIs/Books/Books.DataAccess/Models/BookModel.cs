using Books.DataAccess.Models.Interfaces;
using Domain.Common.Interfaces.DataAccess;

namespace Books.DataAccess.Models;

public class BookModel : IBookModel
{
    public Guid Id { get; }
    public string Name { get; }
    public string Author { get; }
}