#pragma warning disable CS8618

namespace CraftShop.Models;

public class OrderViewHistory 
{
    public List<Craft> Sales {get;set;} = new List<Craft>();
     public List<Craft> Orders {get;set;} = new List<Craft>();
}