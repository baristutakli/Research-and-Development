using MongoDB.Bson.Serialization.Attributes;
using MongoDBProject.Entities.Abstract;
using System.Text.Json.Serialization;

namespace MongoDBProject.Entities
{
    public class Playlist:BaseEntity
    {
        public string UserName { get; set; } = null!;
        [BsonElement("Items")]
        [JsonPropertyName("Items")]
        public List<string> MovieIds { get; set; }

    }
}
