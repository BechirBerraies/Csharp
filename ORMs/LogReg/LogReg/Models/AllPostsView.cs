namespace LogReg.Models;

public class AllPostsView
{
    public List<Post> AllPosts {get;set;} = new();
    public Like Like {get;set;} = new Like();
}