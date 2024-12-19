using System.ComponentModel.DataAnnotations;

namespace API_Web_Project.Model
{
    public class User
    {
        [Key]
        public int UID { get; set; }  // Primary Key

        
        public string Name { get; set; }  

        
        [EmailAddress]  // Built-in validation for email format
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }  // Unique, regex

        
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one letter and one number.")]
        public string Password { get; set; }  // Regex

        
        public string Phone { get; set; }  

        
        public string Role { get; set; }  

        public DateTime CreatedAt { get; set; }  // DateTime


        // Relationships
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }

}
