using eshop.DataOperations.Repositories;
using eshop.Entities;

namespace eshop.Application
{
    public class ProductService : IProductService
    {

        private readonly IProductRespository productRepository;

        public ProductService(IProductRespository productRespository)
        {
            productRepository = productRespository;
        }

        public Product? GetProduct(int id)
        {
            return productRepository.GetById(id);
        }

        public List<Product> GetProducts()
        {
            return productRepository.GetAll().ToList();
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return productRepository.GetAll().Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
