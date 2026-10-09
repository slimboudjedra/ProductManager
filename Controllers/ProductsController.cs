using ProductManager.Mappers;
using ProductManager.Services;
using ProductManager.ViewModels;
using ProductManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProductManager.Controllers
{
    public class ProductsController(ProductService productService) : Controller
    {
        public IActionResult Index()
        {
            return View(productService.GetAllProducts());
        }
        public IActionResult Details(int id)
        {
            var product = productService.GetById(id);
            Product? product1 = product;
            if (product1 == null)
            {
                return NotFound();
            }
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                CreateProductViewModel productViewModel1 = productViewModel;
                productService.AddProduct(ProductMapper.ToProductFromCreate(productViewModel1));
                return RedirectToAction(nameof(Index));
            }
            return View(productViewModel);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            var productViewModel = ProductMapper.ToEditProductViewModel(product);
            return View(productViewModel);
        }
        [HttpPost]
        public IActionResult Edit(EditProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                if(!productService.UpdateProduct(ProductMapper.ToProductFromEdit(productViewModel)))
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productViewModel);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            if(!productService.DeleteProduct(id))
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
