#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DishesOneToMany.Models;
public  class Chef
{
    [Key]
    public int ChefId { get; set; }


    [Required(ErrorMessage = "Please add the First Name of the cook .")]
    [MinLength(3, ErrorMessage = "Name must be at least 3 .")]
    public string FirstName { get; set; }
    [Required]
    [MinLength(3, ErrorMessage = "Please enter a valid Lastname .")]
    public string LastName { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
    public List<Dish> MyDishes { get; set; } = new List<Dish>{};

}