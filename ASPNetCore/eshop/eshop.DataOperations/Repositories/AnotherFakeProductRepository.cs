using eshop.Entities;
using System.Linq.Expressions;

namespace eshop.DataOperations.Repositories
{
    public class AnotherFakeProductRepository : IProductRespository
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            return new List<Product>()
           {
               new(){ Id=1, Name="Alernate 1" },
               new(){ Id=2, Name="Alernate 2" },
               new(){ Id=3, Name="Alernate 4" },
               new(){ Id=4, Name="Alernate 3" }
           };
        }

        public IList<Product> GetByCriteria(Expression<Func<Product, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetProductsByName(string productName)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
