#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Product.Models;
public  class Produit
{
    [Key]
    public int ProductId { get; set; }
    
    [Required(ErrorMessage = "Please add a Name to the Dish .")]
    [MinLength(3, ErrorMessage = "Title must be at least 3 .")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please add a Name to the Dish .")]
    [MinLength(3, ErrorMessage = "Title must be at least 3 .")]
    public string Description { get; set; }

    [Required]
    public int Price { get; set; }

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;


}