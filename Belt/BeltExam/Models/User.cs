#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // New import for ****
namespace BeltExam.Models;

public class User
{
    // User Id
    [Key]
    public int UserId { get; set; }



    // Username
    [Required(ErrorMessage = "Please enter your firstname.")]
    [MinLength(3, ErrorMessage = "Please enter a valid firstname .")]
    public string FirstName { get; set; }

    // Username
    [Required(ErrorMessage = "Please enter your lastname.")]
    [MinLength(3, ErrorMessage = "Please enter a valid lastname .")]
    public string LastName { get; set; }

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


    // Add the navigation property Here

    public List <Project> MyProjects {get; set;}=  new List<Project>();

    public List <Support> MySupports {get; set;}=  new List<Support>();
}
