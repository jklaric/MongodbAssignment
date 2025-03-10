public class BlogService
{
    private readonly BlogRepository _blogRepository;

    public BlogService(BlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }

    public async Task CreateBlogAsync(Blog blog)
    {
        blog.CreatedAt = DateTime.UtcNow;
        blog.UpdatedAt = DateTime.UtcNow;
        await _blogRepository.CreateAsync(blog);
    }

    public async Task UpdateBlogAsync(ObjectId blogId, Blog blog)
    {
        blog.UpdatedAt = DateTime.UtcNow;
        await _blogRepository.UpdateAsync(blogId, blog);
    }

    public async Task DeleteBlogAsync(ObjectId blogId)
    {
        await _blogRepository.DeleteAsync(blogId);
    }
}