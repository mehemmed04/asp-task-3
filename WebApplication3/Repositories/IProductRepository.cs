using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication3.Entities;

namespace WebApplication3.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        Task<List<Product>> GetAllAsync();
    }
}
