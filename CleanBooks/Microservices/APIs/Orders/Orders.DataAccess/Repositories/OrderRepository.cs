using Books.DataAccess.Repositories.Orders.DataAccess.Models.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using Orders.DataAccess.Repositories.Interfaces;

namespace Orders.DataAccess.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly IMongoCollection<IOrderEntity> _collection;

    public OrderRepository()
    {
        var hostname = "localhost";
        var databaseName = "cleanBooksDb";
        var connectionString = $"mongodb://{hostname}:27017";

        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        _collection = database.GetCollection<IOrderEntity>("orders", new MongoCollectionSettings() { AssignIdOnInsert = true });
    }


    public async Task<IOrderEntity?> GetByIdAsync(ObjectId id)
    {
        var result = await _collection.FindAsync(o => o.Id == id);
        return result.ToEnumerable().FirstOrDefault();
    }

    public async Task<IEnumerable<IOrderEntity>> GetAllAsync()
    {
        var result = await _collection.FindAsync(_ => true);
        return result.ToEnumerable();
    }

    public async Task AddAsync(IOrderEntity entity)
    { 
        await _collection.InsertOneAsync(entity);
    }

    public async Task UpdateAsync(IOrderEntity entity, ObjectId id)
    {
        var filter = Builders<IOrderEntity>.Filter.Eq("Id", id);
        await _collection.ReplaceOneAsync(filter, entity, new ReplaceOptions { IsUpsert = true });
    }

    public async Task DeleteAsync(ObjectId id)
    {
        var filter = Builders<IOrderEntity>.Filter.Eq("Id", id);
        await _collection.FindOneAndDeleteAsync(filter);
    }
}