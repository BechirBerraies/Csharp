#pragma warning disable CS8618

namespace CraftShop.Models;

public class OrderView 
{
    public Order NewOrder { get; set; }
    public int OwnerId { get; set; }
}