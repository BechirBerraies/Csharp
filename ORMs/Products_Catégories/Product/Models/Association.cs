#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Product.Models;
public  class Association
{
    [Key]
    public int AssociationId { get; set; }
    
    [Required]
    public int ProductId { get; set; }

    [Required]
    public int CategorieId { get; set; }

    
    
    
    //! Navigation Property
    public Categories? IsIn { get; set; }

    public Produit? Has {get;set;}

}