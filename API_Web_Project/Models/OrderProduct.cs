﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Web_Project.Model
{
    public class OrderProduct
    {
        public int OrderId { get; set; }  // Foreign Key to Order

        public int ProductId { get; set; }  // Foreign Key to Product

        public int Quantity { get; set; }  // Required, must be > 0

        // Relationships
        public Order Order { get; set; }

        [JsonIgnore]
        public Product Product { get; set; }
    }

}
