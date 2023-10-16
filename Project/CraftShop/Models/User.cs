#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // New import for ****
namespace CraftShop.Models;

public class User
{
    // User Id
    [Key]
    public int UserId { get; set; }

    // Username
    [Required(ErrorMessage = "Please enter your username.")]
    [MinLength(3, ErrorMessage = "Please enter a valid username .")]
    public string Username { get; set; }

    // Email
    [Required(ErrorMessage = "Please enter your email.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email.")]
    public string Email { get; set; }

    // Password
    [Required(ErrorMessage = "Please enter your password.")]
    [DataType(DataType.Password)] // useful
    [MinLength(6, ErrorMessage = "Please enter a valid Password .")]
    public string Password { get; set; }

    // Confirm Password
    [NotMapped]
    [Required(ErrorMessage = "Please enter your password.")]
    [Compare("Password", ErrorMessage = "Passwords must match.")]
    [DataType(DataType.Password)] // useful
    [Display(Name = "Confirm Password ")]
    public string ConfirmPassword { get; set; }

    // Created At
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Updated At
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


    // navigation property 


    public List<Craft> MyCrafts {get;set;} = new List <Craft>(); // USer Crafts 
    public List<Order> MyOrders {get;set;} = new List <Order>(); // User Orders 

}