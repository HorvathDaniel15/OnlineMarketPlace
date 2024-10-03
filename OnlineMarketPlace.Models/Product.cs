using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPlace.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A név megadása kötelező")]
        [StringLength(100, ErrorMessage = "A név maximum 100 karakter lehet")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "A leírás maximum 500 karakter lehet")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Az ár megadása kötelező")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Az ár nem lehet null vagy negatív")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }

    }
}
