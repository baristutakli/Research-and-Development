using MongoDB.Driver;

namespace MongoDBProject.Common.Context
{
    public interface IMongoContext
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
