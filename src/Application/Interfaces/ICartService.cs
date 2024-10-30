using Domain.Entitites;

namespace Application.Interfaces
{
    public interface ICartService
    {
        public List<Cart> GetCarts();

        public Cart GetCartById(int id);

        public void AddCart(Cart cart);

        public void UpdateCart(int id, Cart cart);
        public void DeleteCart(int id);
    }
}