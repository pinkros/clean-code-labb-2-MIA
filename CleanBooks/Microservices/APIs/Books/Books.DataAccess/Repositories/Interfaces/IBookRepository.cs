using Books.DataAccess.Models;
using Books.DataAccess.Models.Interfaces;
using Domain.Common.Interfaces.DataAccess;

namespace Books.DataAccess.Repositories.Interfaces;

public interface IBookRepository : IGenericRepository<BookModel, Guid>
{

}