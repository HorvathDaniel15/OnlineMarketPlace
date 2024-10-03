using System.ComponentModel.DataAnnotations;

namespace OnlineMarketPlace.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A rendelés azonosítója megadása kötelező.")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "A termék azonosítója megadása kötelező.")]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Required(ErrorMessage = "A mennyiség megadása kötelező.")]
        [Range(1, int.MaxValue, ErrorMessage = "A mennyiség legalább 1 kell legyen.")]
        public int Quantity { get; set; }
    }
}