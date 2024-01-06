using Domain;
using Domain.Models;
using Infrastucure;



Post post = new Post();
post.Id = 1;
post.Tittle = "Mustafo";
post.Description = "Ofarin";
post.Category = 100;

PostService.CreatePost(post);
foreach (var item in PostService.posts)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Tittle);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine(item.Category);
    
}
Category category = new Category();
category.Id = 2;
category.Name = "Barotov";



foreach (var item in CategoryService.categori)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Name);
    
    
}