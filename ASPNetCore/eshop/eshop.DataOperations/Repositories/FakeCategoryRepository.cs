using eshop.Entities;
using System.Linq.Expressions;

namespace eshop.DataOperations.Repositories
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAll()
        {
            return new List<Category>()
           {
               new(){ Id=1, Name="Ayakkabı"},
               new(){ Id=2, Name="Pantolon"},
               new(){ Id=3, Name="Ceket"},
               new(){ Id=4, Name="Gömlek"},

           };
        }

        public IList<Category> GetByCriteria(Expression<Func<Category, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
