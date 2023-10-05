namespace ProjectName.Models;
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
public class Song
{
    [Required (ErrorMessage = "Please add a Title .")]
    [MinLength(3, ErrorMessage ="Title must be at least 3 . ")]
    public string Title { get; set; }
    [Required (ErrorMessage = "Please add a ReleaseYear .")]
    [Range(1900,2024, ErrorMessage ="Release year must be at least 1 year old  . ")]
    public int ReleaseYear { get; set; }
    [Required (ErrorMessage = "Please add a Singer .")]
    [MinLength(3, ErrorMessage ="Singer Name must be at least 3 characters   . ")]
    public string Singer {get; set;}
    [Required]
    public bool IsExplicit {get;set;}
}
