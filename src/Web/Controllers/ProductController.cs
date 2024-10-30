using Application.DTOs;
using Application.Interfaces;
using Domain.Entitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllProducts()
        {
            return Ok(_productService.GetProducts());
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(_productService.GetProductById(id));
        }

        [HttpPost("[action]")]
        public IActionResult AddProduct([FromBody] Product Product)
        {
            _productService.AddProduct(Product);
            return Ok("Producto agregado con exito!");
        }

        [HttpPut("[action]/{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product Product)
        {
            _productService.UpdateProduct(id, Product);
            return Ok("Producto actualizado con exito!");
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return Ok("Producto eliminado con exito!");
        }

    }
}
