using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace DesafioATS.Infrastructure.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetSection("MongoDbSettings")["ConnectionString"]);
            _database = client.GetDatabase(configuration.GetSection("MongoDbSettings")["DatabaseName"]);
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
