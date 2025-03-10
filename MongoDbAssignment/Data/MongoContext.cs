using MongoDB.Driver;

public class MongoContext
{
    private readonly IMongoDatabase _database;

    public MongoContext(string connectionString, string dbName)
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(dbName);
    }

    public IMongoCollection<Blog> Blogs => _database.GetCollection<Blog>("blogs");
    public IMongoCollection<Post> Posts => _database.GetCollection<Post>("posts");
    public IMongoCollection<Comment> Comments => _database.GetCollection<Comment>("comments");
}