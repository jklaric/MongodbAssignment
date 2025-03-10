public class PostService
{
    private readonly PostRepository _postRepository;

    public PostService(PostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task CreatePostAsync(Post post)
    {
        post.CreatedAt = DateTime.UtcNow;
        post.UpdatedAt = DateTime.UtcNow;
        await _postRepository.CreateAsync(post);
    }

    public async Task UpdatePostAsync(ObjectId postId, Post post)
    {
        post.UpdatedAt = DateTime.UtcNow;
        await _postRepository.UpdateAsync(postId, post);
    }

    public async Task DeletePostAsync(ObjectId postId)
    {
        await _postRepository.DeleteAsync(postId);
    }
}