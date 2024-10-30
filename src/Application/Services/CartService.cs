using Application.Interfaces;
using Domain.Entitites;
using Domain.Interfaces;

namespace Application.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public List<Cart> GetCarts()
        {
            return _cartRepository.GetAll();
        }

        public Cart GetCartById(int id)
        {
            return _cartRepository.GetById(id);
        }

        public void AddCart(Cart cart)
        {
            _cartRepository.Add(cart);
        }

        public void UpdateCart(int id, Cart cart)
        {
            _cartRepository.Update(id, cart);
        }
        public void DeleteCart(int id)
        {
            var cart = _cartRepository.GetById(id);
            _cartRepository.Delete(cart);
        }
    }
}
