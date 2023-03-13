using eshop.Entities;

namespace eshop.Application
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}