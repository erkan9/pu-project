using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {

        private List<Product> products;

        public ProductInMemoryRepository()
        {
            products = new List<Product>()
            {
                new Product { ProductId = 1, CategoryId = 1, Name = "Vodka", Quanity = 500, Price = 5.45, Description = "Russian Vodka"},
                 new Product { ProductId = 2, CategoryId = 2, Name = "M&M", Quanity = 90, Price = 2.45, Description = "Bonibons"},
                 new Product { ProductId = 3, CategoryId = 3, Name = "Bread", Quanity = 100, Price = 0.55, Description = "Wheat Bread"},
                 new Product { ProductId = 4, CategoryId = 1, Name = "Beer", Quanity = 455, Price = 0.45, Description = "Swedish Beer"},
            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);

                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }

            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);

            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quanity = product.Quanity;
                productToUpdate.Description = product.Description;
            }
        }

        public Product GetProductById(int productId)
        {
           return products.FirstOrDefault(x => x.ProductId == productId);
        }

        public void DeleteProduct(int productId)
        {
            var productToDelete = GetProductById(productId);

            if(productToDelete != null)
            {
                products.Remove(productToDelete);
            }
        }
    }
}
