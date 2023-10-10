using Microsoft.EntityFrameworkCore;
namespace Entity.Models;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions options) :base(options){}
    // add ALl Tables Here 
    // -access modifier type DbSet<Model> table name getter setter 
    public DbSet<Song> Songs {get;set;}
}