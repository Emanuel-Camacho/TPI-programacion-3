using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Entities;
using Web.Repositories;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            ProductRepositorie productRepositorie = new ProductRepositorie();
            List<Product> products = productRepositorie.Products;
            return Ok(products);
        }

        [HttpGet("{nameForSearch}")]
        public IActionResult Get(string nameForSearch)
        {
            ProductRepositorie productRepositorie = new ProductRepositorie();
            List<Product> products = productRepositorie.Products;
            return Ok(products.Where(p => p.Name.Contains(nameForSearch)));
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            ProductRepositorie productRepositorie = new ProductRepositorie();
            List<Product> products = productRepositorie.Products;
            products.Add(product);
            return Ok(products);
        }
    }
}
