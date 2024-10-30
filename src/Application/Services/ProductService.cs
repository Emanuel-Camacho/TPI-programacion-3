using Application.Interfaces;
using Domain.Entitites;
using Domain.Interfaces;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
        }

        public void UpdateProduct(int id, Product product)
        {
            _productRepository.Update(id, product);
        }
        public void DeleteProduct(int id)
        {
            var product = _productRepository.GetById(id);
            _productRepository.Delete(product);
        }
    }
}

