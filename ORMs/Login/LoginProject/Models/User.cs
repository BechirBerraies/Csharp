#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // new import for ***

namespace LoginProject.Models;

public class User
{
    [Key]
    public int UserId {get;set;}
    // Username 
    [Required(ErrorMessage = "Please enter your username")]
    [MinLength(3,ErrorMessage ="Enter valid username")]
    public string Username { get; set; }
    [Required(ErrorMessage = "Please enter your Email")]
    [EmailAddress]
    //Email

    //Lucky Number 
    public string Email {get;set;}
    [Required(ErrorMessage = "Please enter your password")]
    [DataType(DataType.Password)]
    [MinLength(6,ErrorMessage ="Password must be valid")]
    public string Password {get;set;}
    [Required(ErrorMessage ="aeara")]
    [Range(0,int.MaxValue,ErrorMessage ="Please enter a valid number ")]
    [Display(Name="Lucky Number")]
    public int Lucky { get; set; }


    
    //is Subscribed 
    [Required]
    [Display(Name="Do you want to subscribe to our newsletter ?")]
    public bool IsSubscribed {get;set;}

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
