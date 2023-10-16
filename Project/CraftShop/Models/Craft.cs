
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // New import for ****
namespace CraftShop.Models;


public class Craft {
    [Key]
    public int CraftId {get;set;}


    [Required]
    // foreign key 
    public int UserId {get;set;}
    public User? Owner {get;set;} // OTM USER CRAFTS


    [Required(ErrorMessage="Please enter image url")]
    [DataType(DataType.Url, ErrorMessage = "Please enter valid url")]
    public string ImageUrl {get;set;}

    [Required(ErrorMessage="Please enter Price ")]
    [Range(0,double.MaxValue,ErrorMessage="Please enter valid Price")]
    public double Price {get;set;}


    [Required(ErrorMessage =" Enter title ")]
    public string Title {get;set;}


    [Required(ErrorMessage= "Please enter Quantity")]
    [Range(0,Int32.MaxValue, ErrorMessage="Please enter valid Quantitty")]
    public int Quantity {get;set;}


    [Required(ErrorMessage="Enter a desciption")]
    [MinLength(10,ErrorMessage ="Please enter a valid description ")]
    public string Description {get;set;}

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


    public List<Order> OrderedCrafts {get;set;} = new List <Order>(); // OTM Crafts Orders 


}