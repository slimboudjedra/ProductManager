using ProductManager.Models;
using ProductManager.ViewModels;

namespace ProductManager.Mappers;

static class ProductMapper
    {
        public static Product ToProductFromCreate(CreateProductViewModel viewModel)
        {
            return new Product
            {
                Name = viewModel.Name,
                Description = viewModel.Description,
                Price = viewModel.Price
            };
        }

        public static Product ToProductFromEdit(EditProductViewModel viewModel)
        {
            return new Product
            {
                Id = viewModel.Id,
                Name = viewModel.Name ?? string.Empty,
                Description = viewModel.Description ?? string.Empty,
                Price = viewModel.Price
            };
        }

        public static EditProductViewModel ToEditProductViewModel(Product product)
        {
            return new EditProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price
            };
        }

    }

