#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Dishes.Models;
public  class Dish
{
    [Key]
    public int DishId { get; set; }


    [Required(ErrorMessage = "Please add a Name to the Dish .")]
    [MinLength(3, ErrorMessage = "Title must be at least 3 .")]
    public string Name { get; set; }
    [Required]
    [MinLength(3, ErrorMessage = "Please enter a valid Chef .")]
    public string Chef { get; set; }
    [Required]
    [Range(1,5, ErrorMessage= "Value must be between 1 and 5 ")]
    public int Tastiness { get; set; }
    [Required]
    public int Calories { get; set; }
    [Required(ErrorMessage = "Please Get a description for your Dish.")]
    [MinLength(5, ErrorMessage = "Title must be at least 3 .")]
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


}