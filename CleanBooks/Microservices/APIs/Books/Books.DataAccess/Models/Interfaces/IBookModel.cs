using Domain.Common.Interfaces.DataAccess;

namespace Books.DataAccess.Models.Interfaces;

public interface IBookModel : IEntity<Guid>
{
    string Name { get; }
    string Author { get; }
}