using Domain.Entitites;
using Domain.Interfaces;

namespace Infrastructure.Data
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly ApplicationContext _context;

        public ProductRepository(ApplicationContext context)
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
