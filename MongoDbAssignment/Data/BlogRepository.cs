using MongoDB.Driver;
using MongoDB.Bson;

public class BlogRepository
{
    private readonly MongoContext _context;

    public BlogRepository(MongoContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Blog blog)
    {
        await _context.Blogs.InsertOneAsync(blog);
    }

    public async Task<Blog> GetByIdAsync(ObjectId blogId)
    {
        return await _context.Blogs.Find(b => b.Id == blogId).FirstOrDefaultAsync();
    }

    public async Task UpdateAsync(ObjectId blogId, Blog blog)
    {
        await _context.Blogs.ReplaceOneAsync(b => b.Id == blogId, blog);
    }

    public async Task DeleteAsync(ObjectId blogId)
    {
        await _context.Blogs.DeleteOneAsync(b => b.Id == blogId);
    }
}