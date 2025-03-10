using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Post
{
    [BsonId]
    public ObjectId Id { get; set; }
    public ObjectId BlogId { get; set; }
    public ObjectId AuthorId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}