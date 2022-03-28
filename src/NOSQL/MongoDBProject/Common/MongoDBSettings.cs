using MongoDBProject.Common.Interfaces;

namespace MongoDBProject.Common
{
    public class MongoDBSettings:IMongoDBSettings
    {
        public string ConnectionURI { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string CollectionName { get; set; } = null!;
    }
}
