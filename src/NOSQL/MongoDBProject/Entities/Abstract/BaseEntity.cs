using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBProject.Entities.Abstract
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public ObjectId Id { get; set; }
        public DateTime CreatedAt { get; set; }
            
    }
}
