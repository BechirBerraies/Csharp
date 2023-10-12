#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // new import for ***

namespace LogReg.Models;

public class Post
{
    //Post Id
    [Key]
    public int PostId {get;set;}

    //! Foreign key for user

    [Required]
    public int UserId { get; set; }
    
    // FirstName 
    [Required(ErrorMessage = "Please enter your title")]
    [MinLength(2,ErrorMessage ="Enter valid title")]
    public string Title { get; set; }

    //LastName
    [Required(ErrorMessage = "Please enter your Subject")]
    [MinLength(2,ErrorMessage ="Enter valid Subject")]
    public string Subject { get; set; }

    [Required(ErrorMessage = "Please enter your Content")]
    [MinLength(10,ErrorMessage ="Enter valid Content")]
    public string Content { get; set; }

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    //! Navigation Property
    public User? Poster { get; set; }

}
