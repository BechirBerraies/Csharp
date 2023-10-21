#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // new import for ***

namespace BeltExam.Models;

public class Support
{
    //Post Id
    [Key]
    public int SupportId {get;set;}

    //! Foreign key for user

    [Required]
    public int ProjectId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required(ErrorMessage = "Please enter your Amount.")]
    [Range(3,Int32.MaxValue, ErrorMessage = "Please enter a valid Amount .")]
    public int Amount { get; set; }
    


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // //! Navigation Property
    public Project? Project { get; set; }
    public User? User { get; set; }
}
