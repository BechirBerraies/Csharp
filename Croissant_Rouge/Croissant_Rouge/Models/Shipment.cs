using System;
using System.ComponentModel.DataAnnotations;

namespace Croissant_Rouge.Models
{
    public class Shipment
    {
        [Key]
        public int ShipmentId { get; set; }

        public int UserId { get; set; }
        public User? Shipper { get; set; }

        public int DonationId { get; set; }
        public Donation? Donation { get; set; }

        //Shipping Status
        public enum Shipstatuses
        {
            uncomfirmed, Accepted, InShipping, Received
        }
        [Required(ErrorMessage = "What is your Status")]
        public Shipstatuses ShipStatus { get; set; }

        // Created At
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Updated At
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Add the navigation property Here
    }
}