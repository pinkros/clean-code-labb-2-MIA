using Books.DataAccess.Models;
using Books.DataAccess.Repositories.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Books.DataAccess.Repositories;

public class BookRepository : IBookRepository
{
    private readonly IMongoCollection<BookModel> _collection;

    public BookRepository()
    {
        var hostname = Environment.GetEnvironmentVariable("DB_HOST");
        var databaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
        var connectionString = $"mongodb://{hostname}:27017";

        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        _collection = database.GetCollection<BookModel>("Questions", new MongoCollectionSettings() { AssignIdOnInsert = true });
    }


    public async Task<BookModel> GetByIdAsync(ObjectId id)
    {
        var filter = Builders<BookModel>.Filter.Eq("_id", id);
        return await _collection.Find(filter).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<BookModel>> GetAllAsync()
    {
        return await _collection.Find(new BsonDocument()).ToListAsync();
    }

    public async Task AddAsync(BookModel entity)
    {
        await _collection.InsertOneAsync(entity);
    }

    public async Task UpdateAsync(BookModel entity)
    {
        var filter = Builders<BookModel>.Filter.Eq("_id", entity.Id);
        await _collection.ReplaceOneAsync(filter, entity);
    }

    public async Task DeleteAsync(ObjectId id)
    {
        var filter = Builders<BookModel>.Filter.Eq("_id", id);
        await _collection.DeleteOneAsync(filter);
    }
}