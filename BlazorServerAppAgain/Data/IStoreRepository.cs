using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerAppAgain.Data
{
   public interface IStoreRepository
    {
        Task<List<Product>> GetProducts();
        Task AddProduct(Product product);
        Task<Product> GetProductById(int id);

        Task UpdateProduct(Product product);


    }
}
