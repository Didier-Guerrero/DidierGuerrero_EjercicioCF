using System.ComponentModel.DataAnnotations;

namespace DidierGuerrero_EjercicioCF.Models
{
    public class Burger
    {
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 99.99)]
        public decimal Price { get; set; }
    }
}
