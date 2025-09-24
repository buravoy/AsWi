using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HSx.Models;

public class NatalCard
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
}
