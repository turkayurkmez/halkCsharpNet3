using eshop.DataOperations.Repositories;
using eshop.Entities;

namespace eshop.Application
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public IList<Category> GetCategories()
        {
            return _repository.GetAll();
        }
    }
}
