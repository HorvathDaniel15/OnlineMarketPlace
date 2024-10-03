using System.ComponentModel.DataAnnotations;

namespace OnlineMarketPlace.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A vásárló azonosítója megadása kötelező.")]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "A rendelés időpontjának megadása kötelező.")]
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}