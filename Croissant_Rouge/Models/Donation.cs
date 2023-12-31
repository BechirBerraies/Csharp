﻿using System;
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Croissant_Rouge.Models
{
    public class Donation
    {
        // Donation Id
        [Key]
        public int DonationId { get; set; }

        //! Foreign Key

        [Required]
        public int UserId { get; set; }

        // Title
        [Required(ErrorMessage = "Please enter your firstname.")]
        [MinLength(3, ErrorMessage = "Please enter a valid firstname .")]
        public string Title { get; set; }


        // Quantity 
        [Required(ErrorMessage = "Please enter your Quantity.")]
        [MinLength(3, ErrorMessage = "Please enter a valid Quantity .")]
        public string Quantity { get; set; }


        //Description
        [Required(ErrorMessage = "Please enter your Description.")]
        [MinLength(3, ErrorMessage = "Please enter a valid Description .")]
        public string Description { get; set; }


        //Picture
        [Required(ErrorMessage = "Please enter your Picture.")]
        [MinLength(3, ErrorMessage = "Please enter a valid Picture .")]
        public string Picture { get; set; }


        //Category

        public enum Categories
        {
            Clothing, Equipment, Food, Medication
        }
        [Required(ErrorMessage = "What is your Category")]
        public Categories Category { get; set; }


        public enum statuses
        {
            Unvalid, Valid
        }
        [Required(ErrorMessage = "What is your Category")]
        public statuses status { get; set; }



        // Created At
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Updated At
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Add the navigation property Here

        public User? Donner { get; set; }

        public Shipment? Shipment { get; set; }
    }
}

