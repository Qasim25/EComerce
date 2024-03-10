using EComerce.Server.Models;

namespace EComerce.Server.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
    }
}
