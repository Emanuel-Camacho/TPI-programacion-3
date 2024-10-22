using Web.Data;
using Web.Entities;

namespace Web.Data.Repositories
{
    public class ProductRepositorie
    {
        private readonly ApplicationContext _context;
        public ProductRepositorie(ApplicationContext context)
        {
            _context = context;
        }
        public List<Product> Get()
        {
            return _context.Products.ToList();
        }
        public int Add(Product prod)
        {
            _context.Products.Add(prod);
            _context.SaveChanges();
            return prod.Id;
        }
    }
}
