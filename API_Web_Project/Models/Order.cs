using System.ComponentModel.DataAnnotations;

namespace API_Web_Project.Model
{
    public class Order
    {
        [Key]
        public int OID { get; set; }  // Primary Key

        public int UserId { get; set; }  // Foreign Key to User

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }  // Calculated from OrderProducts

        // Relationships
        public User User { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }

}
