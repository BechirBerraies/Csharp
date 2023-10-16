#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
namespace CraftShop.Models;
public class CraftShopContext : DbContext 
{ 
    public CraftShopContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }

    public DbSet<Craft> Crafts { get; set; }
    
}