﻿using System.ComponentModel.DataAnnotations;

namespace API_Web_Project.Model
{
    public class Product
    {
        [Key]
        public int PID { get; set; }  // Primary Key

        
        public string Name { get; set; }  // Required

        public string Description { get; set; }

       
        public decimal Price { get; set; }  // Required and must be > 0

        
        public int Stock { get; set; }  // Required and must be >= 0

        public decimal OverallRating { get; set; }  // Calculated from reviews

        // Relationships
        public ICollection<Review> Reviews { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }

}
