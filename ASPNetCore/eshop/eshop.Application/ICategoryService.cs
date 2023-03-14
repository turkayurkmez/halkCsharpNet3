using eshop.Entities;

namespace eshop.Application
{
    public interface ICategoryService
    {
        IList<Category> GetCategories();
    }
}