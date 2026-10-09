using System.ComponentModel.DataAnnotations;

namespace ProductManager.ViewModels;

public class CreateProductViewModel
    {
        [Required(ErrorMessage = "Product name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Product description is required.")]
        public string Description { get; set; } = string.Empty;

        [Range(0.1,9999999)]
        public decimal Price { get; set; }

    }

