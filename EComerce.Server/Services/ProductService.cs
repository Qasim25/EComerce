using EComerce.Server.Data;
using EComerce.Server.Interface;
using EComerce.Server.Models;
using System.Linq;

namespace EComerce.Server.Services
{
    public class ProductService: IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

   

    }
}
