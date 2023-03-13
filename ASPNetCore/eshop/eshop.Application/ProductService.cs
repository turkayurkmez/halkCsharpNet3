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


        public List<Product> GetProducts()
        {
            return productRepository.GetAll().ToList();
        }
    }
}
