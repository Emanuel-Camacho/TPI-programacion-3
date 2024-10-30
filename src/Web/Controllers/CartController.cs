using Application.DTOs;
using Application.Interfaces;
using Domain.Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllCarts()
        {
            return Ok(_cartService.GetCarts());
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetCartById(int id)
        {
            return Ok(_cartService.GetCartById(id));
        }

        [HttpPost("[action]")]
        public IActionResult AddCart([FromBody] Cart cart)
        {
            _cartService.AddCart(cart);
            return Ok("Carrito agregado con exito!");
        }

        [HttpPut("[action]/{id}")]
        public IActionResult UpdateCart(int id, [FromBody] Cart cart)
        {
            _cartService.UpdateCart(id, cart);
            return Ok("Carrito actualizado con exito!");
        }

        [HttpDelete]
        public IActionResult DeleteCart(int id)
        {
            _cartService.DeleteCart(id);
            return Ok("Carrito eliminado con exito!");
        }

    }
}
