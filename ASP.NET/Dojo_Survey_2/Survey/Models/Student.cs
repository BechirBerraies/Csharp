namespace Survey.Models;
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
public class Student
{
    [Required]
    [MinLength(2,ErrorMessage ="Name is Required and at least 2 characters")]
    public string Name { get; set; }
    [Required]
    [MinLength(2,ErrorMessage= "Location is required")]
    public string Location { get; set; }
    [Required]
    [MinLength(2,ErrorMessage="Error message Language")]
    public string Language { get; set; }

    [MinLength(20,ErrorMessage="Comment Should at least be 20 carachters")]

    public string Comment { get; set; }
}
