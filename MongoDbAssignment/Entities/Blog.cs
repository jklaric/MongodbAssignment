using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Blog
{
    [BsonId]
    public ObjectId Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public ObjectId UserId { get; set; }
    public DateTime CreatedAt { get; set; }
}