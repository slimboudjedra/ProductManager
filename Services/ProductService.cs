using ProductManager.Models;

namespace ProductManager.Services;

public class ProductService
    {
        private readonly List<Product> _products = new();
        
        public ProductService()
        {
            _products.Add(new Product
            {
                Id = 1,
                Name = "Logitech MX Master 3S",
                Description = "Ergonomische kabellose Maus mit präzisem Sensor und leisem Klickgeräusch.",
                Price = 99.99m
            });

            _products.Add(new Product
            {
                Id = 2,
                Name = "Samsung 990 EVO Plus 1TB",
                Description = "Interne NVMe-SSD mit 1 TB Speicherplatz für schnelle Datenübertragung.",
                Price = 89.90m
            });

            _products.Add(new Product
            {
                Id = 3,
                Name = "Dell UltraSharp 27 Zoll",
                Description = "27-Zoll-Monitor mit hoher Auflösung für Büroarbeit und Multimedia.",
                Price = 349.00m
            });

            _products.Add(new Product
            {
                Id = 4,
                Name = "Keychron K2",
                Description = "Mechanische kabellose Tastatur mit kompaktem Layout für produktives Arbeiten.",
                Price = 89.99m
            });

            _products.Add(new Product
            {
                Id = 5,
                Name = "Anker 735 Charger",
                Description = "Kompaktes USB-C-Ladegerät zum gleichzeitigen Laden mehrerer Geräte.",
                Price = 49.99m
            });
        }



    public Product? GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IReadOnlyList<Product> GetAllProducts()
        {
            return _products;
        }


        public void AddProduct(Product product)
        {
            var maxId = _products.Any() ? _products.Max(p => p.Id) : 0;
            product.Id = maxId + 1;
            _products.Add(product);
        }


        public bool UpdateProduct(Product product)
        {
            var existingProduct = GetById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                return true;
            }
            return false;
        }


        public bool DeleteProduct(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
                return true;
            }
            return false;
        }

    }

