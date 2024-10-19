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
        public IActionResult Get([FromQuery] bool includeDeleted = false)
        {
            if (includeDeleted)
            {
                return Ok(ProductRepositorie.Products);
            }
            else
            {
                return Ok(ProductRepositorie.Products.Where(p => p.State == "Active"));
            }
        }

        [HttpGet("{nameForSearch}")]
        public IActionResult Get(string nameForSearch)
        {
            return Ok(ProductRepositorie.Products.Where(p => p.Name.Contains(nameForSearch)));
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            product.Id = ProductRepositorie.Products.Count() + 1;
            product.State = "Active";
            ProductRepositorie.Products.Add(product);
            return Ok(ProductRepositorie.Products);
        }


        [HttpPut("{idProduct}")]
        public IActionResult Update([FromRoute] int idProduct, [FromBody] Product product)
        {
            int idProductToModify = ProductRepositorie.Products.FindIndex(p => p.Id == idProduct);
            if (idProductToModify != -1)
            {
                Product newProduct = new Product()
                {
                    Id = idProduct,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    Brand = product.Brand,
                    Stock = product.Stock,
                };
                ProductRepositorie.Products[idProductToModify] = newProduct;
                return Ok("Actualizacion exitosa");
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{idProduct}")]
        public IActionResult Delete([FromRoute] int idProduct)
        {
            int idProductToModify = ProductRepositorie.Products.FindIndex(p => p.Id == idProduct);
            if (idProductToModify != -1)
            {
                Product deletedProduct = new Product()
                {
                    Id = idProduct,
                    Name = ProductRepositorie.Products[idProductToModify].Name,
                    Price = ProductRepositorie.Products[idProductToModify].Price,
                    Quantity = ProductRepositorie.Products[idProductToModify].Quantity,
                    Brand = ProductRepositorie.Products[idProductToModify].Brand,
                    Stock = ProductRepositorie.Products[idProductToModify].Stock,
                    State = "Deleted"
                };
                ProductRepositorie.Products[idProductToModify] = deletedProduct;
                return Ok("Eliminacion exitosa");
            }
            return NotFound();
        }

    }
}
