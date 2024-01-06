using Domain.Models;

namespace Infrastucure;

public class CategoryService
{
    public static List<Category> categori = new List<Category>();
    public static void CreatePost(Category categ)
    {
        categori.Add(categ);
    }
    public static List<Category> GetCategory()
    {
        return categori;
    }

    public static Category GetCAtegoryById(int id)
    {
        var categ = categori.FirstOrDefault(e => e.Id == id);
        return categ;

    }
    public static Category GetPostByName(string name)
    {
        var categ = categori.FirstOrDefault(e => e.Name == name);
        return categ;
    }
    public static List<Category> GetPostByDate(DateTime date)
    {
        var categ = categori.FirstOrDefault(e => e.CreatedAt == date);
        return categori;

    }
    public static void DeletePost(int id)
    {
        var categ = categori.FirstOrDefault(e => e.Id == id);
        categori.Remove(categ);
    }

    public static void CreateCategory(Category category)
    {
        throw new NotImplementedException();
    }
}
