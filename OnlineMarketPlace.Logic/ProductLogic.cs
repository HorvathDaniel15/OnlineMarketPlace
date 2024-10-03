using OnlineMarketPlace.Models;
using OnlineMarketPlace.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPlace.Logic
{
    public class ProductLogic : IProductLogic
    {
        private readonly IRepository<Product> _productRepository;

        public ProductLogic(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task CreateProductAsync(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "A termék nem lehet null");
            }
            await _productRepository.CreateAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _productRepository.ReadAsync(id);
            if (product == null)
            {
                throw new Exception("A termék nem található");
            }
            await _productRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.ReadAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.ReadAsync(id);
            if (product == null)
            {
                throw new Exception("A termék nem található");
            }
            return product;
        }

        public async Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm)
        {
            var products = await _productRepository.ReadAllAsync();
            return products.Where(p => p.Name.Contains(searchTerm) || p.Description.Contains(searchTerm));
        }

        public async Task UpdateProductAsync(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "A termék nem lehet null");
            }
            await _productRepository.UpdateAsync(product);
        }
    }
}
