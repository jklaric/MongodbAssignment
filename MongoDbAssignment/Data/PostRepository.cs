using MongoDB.Driver;
using MongoDB.Bson;

public class PostRepository
{
    private readonly MongoContext _context;

    public PostRepository(MongoContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Post post)
    {
        await _context.Posts.InsertOneAsync(post);
    }

    public async Task<Post> GetByIdAsync(ObjectId postId)
    {
        return await _context.Posts.Find(p => p.Id == postId).FirstOrDefaultAsync();
    }

    public async Task UpdateAsync(ObjectId postId, Post post)
    {
        await _context.Posts.ReplaceOneAsync(p => p.Id == postId, post);
    }

    public async Task DeleteAsync(ObjectId postId)
    {
        await _context.Posts.DeleteOneAsync(p => p.Id == postId);
    }
}