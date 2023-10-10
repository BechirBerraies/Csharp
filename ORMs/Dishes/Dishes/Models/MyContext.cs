using Microsoft.EntityFrameworkCore;
namespace Dishes.Models;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions options) :base(options){}
    // add ALl Tables Here 
    // -access modifier type DbSet<Model> table name getter setter 
    public DbSet<Dish> Dishes {get;set;}
}