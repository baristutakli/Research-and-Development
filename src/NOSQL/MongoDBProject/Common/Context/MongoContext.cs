using MongoDB.Driver;
using MongoDBProject.Common.Interfaces;


namespace MongoDBProject.Common.Context
{
    public class MongoContext
    {
        private readonly MongoClient _dBClient;
        private readonly IMongoDatabase _db;
        public MongoContext(IMongoDBSettings settings)
        {
            _dBClient = new MongoClient(settings.ConnectionURI);
            _db = _dBClient.GetDatabase(settings.DatabaseName); 
        }

        public IMongoCollection<T> GetCollection<T>(string name)=> _db.GetCollection<T>(name);
    }
}
