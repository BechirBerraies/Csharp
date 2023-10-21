#pragma warning disable CS8618
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // New import for **
namespace BeltExam.Models;


public class FuturDate : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if ((DateTime)value < DateTime.Now)
            return new ValidationResult("Date must be in the Futur");
        return ValidationResult.Success;
    }
}




public class Project
{
    // User Id
    [Key]
    public int ProjectId { get; set; }

    [Required]
    public int UserId { get; set; }


    
    [Required(ErrorMessage = "Please enter your Title.")]
    [MinLength(3, ErrorMessage = "Please enter a valid Title .")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Please enter your Goal.")]
    [Range(1,Int32.MaxValue, ErrorMessage = "Please enter a valid Goal .")]
    public int Goal { get; set; }


    [Required(ErrorMessage ="Enter a Valid Date")]
    [FuturDate]
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Please enter your Description.")]
    [MinLength(20, ErrorMessage = "Please enter a  Title with more than 20 carachters.")]

    public string Description { get; set; }

    // Created At
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Updated At
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    //! Navigation Property
    public User? myCreator {get; set;}
    public List<Support> Supporters {get; set;}=  new List<Support>();  
}