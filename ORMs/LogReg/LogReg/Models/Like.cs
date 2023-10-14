#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // new import for ***

namespace LogReg.Models;

public class Like
{
    //Post Id
    [Key]
    public int LikeId {get;set;}

    //! Foreign key for user

    [Required]
    public int PostId { get; set; }

    [Required]
    public int UserId { get; set; }
    


    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    //! Navigation Property
    public Post? Poster { get; set; }

    public User? User {get;set;}

}
