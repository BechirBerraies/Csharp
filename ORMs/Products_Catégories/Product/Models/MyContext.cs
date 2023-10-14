#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore; 
namespace Product.Models;
// the MyContext class representing a session with our MySQL database, allowing us to query for or save data
public class MyContext : DbContext 
{ 
    public MyContext(DbContextOptions options) : base(options) { }
    // the "Monsters" table name will come from the DbSet property name
    public DbSet<Association> Associations { get; set; } 
    public DbSet<Produit> Produits {get;set;}
    public DbSet<Categories> Categories {get;set;}
}



