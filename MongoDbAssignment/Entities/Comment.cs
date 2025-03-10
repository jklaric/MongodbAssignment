using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Comment
{
    [BsonId]
    public ObjectId Id { get; set; }
    public ObjectId PostId { get; set; }
    public ObjectId UserId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}