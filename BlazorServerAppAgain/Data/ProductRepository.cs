using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerAppAgain.Data
{
    public class ProductRepository : IStoreRepository
    {
        private readonly EdurekaDBContext context;

        public ProductRepository(EdurekaDBContext context)
        {
            this.context = context;
        }
        public Task<List<Product>> GetProducts()
        {
            return Task.FromResult(context.Products.ToList());
        }
        public async Task AddProduct(Product product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
        }

        public  async Task<Product> GetProductById(int id)
        {
            return await context.Products.FindAsync(id);
        }

        public async Task UpdateProduct(Product product)
        {
            context.Products.Update(product);
            await context.SaveChangesAsync();
        }
    }
}
