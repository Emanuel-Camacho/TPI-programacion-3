using Domain.Entitites;
using Domain.Interfaces;

namespace Infrastructure.Data
{
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        private readonly ApplicationContext _context;

        public CartRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Cart> Get()
        {
            return _context.Carts.ToList();
        }

        public int Add(Cart car)
        {
            _context.Carts.Add(car);
            _context.SaveChanges();
            return car.Id;
        }
    }
}