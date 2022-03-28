namespace MongoDBProject.Common.Interfaces
{
    public interface IMongoDBSettings
    {
        public string ConnectionURI { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}
