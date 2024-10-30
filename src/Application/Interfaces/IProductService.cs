using Domain.Entitites;

namespace Application.Interfaces
{
    public interface IProductService
    {
        public List<Product> GetProducts();

        public Product GetProductById(int id);

        public void AddProduct(Product product);

        public void UpdateProduct(int id, Product product);
        public void DeleteProduct(int id);
    }
}