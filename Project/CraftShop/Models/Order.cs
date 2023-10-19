#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // New import for ****
namespace CraftShop.Models;


public class Order 
{
    [Key]
    public int OrderId {get;set;}



    [Required]
    public int UserId {get;set;}
    public User? Buyer {get;set;}



    [Required]
    public int CraftId {get;set;}
    public Craft? Craft {get;set;}




    [Required(ErrorMessage="How many do you want ")]
    [Range(1,Int32.MaxValue,ErrorMessage ="Please enter valid Quantity")]
    public int Quantity {get;set;}



    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Updated At
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}