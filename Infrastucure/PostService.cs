using Domain.Models;

namespace Infrastucure;

public class PostService
{
    public static List<Post> posts = new List<Post>();
    public static void CreatePost(Post post)
    {
        posts.Add(post);
    }
    public static List<Post> GetPost()
    {
        return posts;
    }

    public static Post GetPostById(int id)
    {
        var post = posts.FirstOrDefault(e => e.Id == id);

        return post;

    }
    public static Post GetPostByName(string tittle)
    {
        var post = posts.FirstOrDefault(e => e.Tittle == tittle);
        return post;
    }
    public static List<Post> GetPostByDate(DateTime date)
    {
        var post = posts.FirstOrDefault(e => e.CreatedAt == date);
        return posts;

    }
    public static List<Post> GetPostByCategory(int id)
    {
        var post = posts.FirstOrDefault(e => e.Id == id);
        return posts;

    }
    public static void DeletePost(int id)
    {
        var post = posts.FirstOrDefault(e => e.Id == id);
        posts.Remove(post);
    }
}
