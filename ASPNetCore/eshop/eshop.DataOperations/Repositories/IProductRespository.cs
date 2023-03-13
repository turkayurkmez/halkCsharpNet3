using eshop.Entities;

namespace eshop.DataOperations.Repositories
{
    public interface IProductRespository : IRepository<Product>
    {
        IList<Product> GetProductsByName(string productName);
    }
}
