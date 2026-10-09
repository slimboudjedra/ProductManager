using System.ComponentModel.DataAnnotations;

namespace ProductManager.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Der Produktname ist erforderlich.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Die Beschreibung ist erforderlich.")]
        public string Description { get; set; } = string.Empty;

        [Range(0.01, 100000,
            ErrorMessage = "Der Preis muss zwischen 0,01 und 100000 liegen.")]
        public decimal Price { get; set; }
    }
}