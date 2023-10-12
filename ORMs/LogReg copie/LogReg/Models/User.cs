#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // new import for ***

namespace LogReg.Models;

public class User
{
    [Key]
    public int UserId {get;set;}
    // FirstName 
    [Required(ErrorMessage = "Please enter your firstname")]
    [MinLength(2,ErrorMessage ="Enter valid username")]
    public string FirstName { get; set; }

    //LastName
    [Required(ErrorMessage = "Please enter your lastname")]
    [MinLength(2,ErrorMessage ="Enter valid username")]
    public string LastName { get; set; }

    
    //Email
    [Required(ErrorMessage = "Please enter your Email")]
    [EmailAddress]
    public string Email {get;set;}
    
    
    
    //Password 
    [Required(ErrorMessage = "Please enter your password")]
    [DataType(DataType.Password)]
    [MinLength(8,ErrorMessage ="Password must be valid")]
    public string Password {get;set;}


    //Confirm Password
    [NotMapped]
    [Required(ErrorMessage = "Please enter your Confirm password")]
    [Compare("Password",ErrorMessage ="Password Must match")]
    [Display(Name="Confirm Password")]
    [DataType(DataType.Password)]
    public string ConfirmPassword {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;


}
