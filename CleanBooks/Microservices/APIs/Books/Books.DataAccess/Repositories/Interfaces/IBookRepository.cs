using Books.DataAccess.Models;
using Domain.Common.Interfaces.DataAccess;
using MongoDB.Bson;

namespace Books.DataAccess.Repositories.Interfaces;

public interface IBookRepository : IGenericRepository<BookModel, ObjectId>
{

}