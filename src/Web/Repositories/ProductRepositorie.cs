using Web.Entities;

namespace Web.Repositories
{
    public class ProductRepositorie
    {
        public List<Product> Products {  get; set; }

        public ProductRepositorie()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    Name = "Producto 1",
                    Id = 1,
                    Price = 100,
                    Quantity = 2,
                    Brand = "marca 1",
                    Stock = 10
                },
                new Product()
                {
                    Name = "Producto 2",
                    Id = 2,
                    Price = 200,
                    Quantity = 2,
                    Brand = "marca 1",
                    Stock = 10
                },
                new Product()
                {
                    Name = "Material",
                    Id = 3,
                    Price = 150,
                    Quantity = 5,
                    Brand = "marca 2",
                    Stock = 15
                }
            };
        }
    }
}
