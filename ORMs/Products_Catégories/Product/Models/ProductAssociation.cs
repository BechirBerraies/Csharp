namespace Product.Models;

public class ProductAssociation
{
    
    public List<Categories> AllCategories {get;set;} = new();
    public Association Associate {get;set;} = new Association();
}