using Books.DataAccess.Repositories.Orders.DataAccess.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Orders.DataAccess.Repositories.Interfaces;

namespace Orders.DataAccess.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly IMongoCollection<OrderEntity> _collection;

    public OrderRepository()
    {
        var hostname = Environment.GetEnvironmentVariable("DB_HOST");
        var databaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
        var connectionString = $"mongodb://{hostname}:27017";

        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        _collection = database.GetCollection<OrderEntity>("Orders", new MongoCollectionSettings() { AssignIdOnInsert = true });
    }


    public async Task<OrderEntity?> GetByIdAsync(ObjectId id)
    {
        var result = await _collection.FindAsync(o => o.Id == id);
        return result.ToEnumerable().FirstOrDefault();
    }

    public async Task<IEnumerable<OrderEntity>> GetAllAsync()
    {
        var result = await _collection.FindAsync(_ => true);
        return result.ToEnumerable();
    }

    public async Task AddAsync(OrderEntity entity)
    { 
        await _collection.InsertOneAsync(entity);
    }

    public async Task UpdateAsync(OrderEntity entity, ObjectId id)
    {
        var filter = Builders<OrderEntity>.Filter.Eq("Id", id);
        await _collection.ReplaceOneAsync(filter, entity, new ReplaceOptions { IsUpsert = true });
    }

    public async Task DeleteAsync(ObjectId id)
    {
        var filter = Builders<OrderEntity>.Filter.Eq("Id", id);
        await _collection.FindOneAndDeleteAsync(filter);
    }
}