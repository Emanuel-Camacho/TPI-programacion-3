using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using Web.Data.Repositories;
using Web.Entities;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepositorie _productRepositorie;
        public ProductController(ProductRepositorie productRepositorie)
        {
            _productRepositorie = productRepositorie;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] bool includeDeleted = false)
        {
            return Ok(_productRepositorie.Get());
        }

        //[HttpGet("{nameForSearch}")]
        //public IActionResult Get(string nameForSearch)
        //{
        //    return Ok(_productRepositorie.Products.Where(p => p.Name.Contains(nameForSearch)));
        //}

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product requestdto)
        {
            Product product = new Product();
            {
                product.Name = requestdto.Name;
                product.Price = requestdto.Price;
                product.Quantity = requestdto.Quantity;
                product.Brand = requestdto.Brand;
                product.Stock = requestdto.Stock;
                product.State = "Active";
                
                
            };
            return Ok(_productRepositorie.Add(product));
        }


        //[HttpPut("{idProduct}")]
        //public IActionResult Update([FromRoute] int idProduct, [FromBody] Product product)
        //{
        //    int idProductToModify = _productRepositorie.Products.FindIndex(p => p.Id == idProduct);
        //    if (idProductToModify != -1)
        //    {
        //        Product newProduct = new Product()
        //        {
        //            Id = idProduct,
        //            Name = product.Name,
        //            Price = product.Price,
        //            Quantity = product.Quantity,
        //            Brand = product.Brand,
        //            Stock = product.Stock,
        //        };
        //        _productRepositorie.Products[idProductToModify] = newProduct;
        //        return Ok("Actualizacion exitosa");
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}
        //[httpdelete("{idproduct}")]
        //public iactionresult delete([fromroute] int idproduct)
        //{
        //    int idproducttomodify = _productrepositorie.products.findindex(p => p.id == idproduct);
        //    if (idproducttomodify != -1)
        //    {
        //        product deletedproduct = new product()
        //        {
        //            id = idproduct,
        //            name = _productrepositorie.products[idproducttomodify].name,
        //            price = _productrepositorie.products[idproducttomodify].price,
        //            quantity = _productrepositorie.products[idproducttomodify].quantity,
        //            brand = _productrepositorie.products[idproducttomodify].brand,
        //            stock = _productrepositorie.products[idproducttomodify].stock,
        //            state = "deleted"
        //        };
        //        _productrepositorie.products[idproducttomodify] = deletedproduct;
        //        return ok("eliminacion exitosa");
        //    }
        //    return notfound();
        //}

    }
}
