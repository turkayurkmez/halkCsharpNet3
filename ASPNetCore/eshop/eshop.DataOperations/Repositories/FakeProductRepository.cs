using eshop.Entities;
using System.Linq.Expressions;

namespace eshop.DataOperations.Repositories
{
    public class FakeProductRepository : IProductRespository
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
            var products = new List<Product>
            {
                new(){ Id=1, Name="Product A", Description="Product A Description", ImageUrl="https://cdn.dsmcdn.com/ty702/product/media/images/20230126/19/266768229/623370682/11/11_org.jpg", Price=1000, Stock=150, DiscountRate=0.90, CategoryId=1},


               new(){ Id=2, Name="Product B", Description="Product B Description", ImageUrl="https://cdn.dsmcdn.com/ty702/product/media/images/20230126/19/266768229/623370682/11/11_org.jpg", Price=1000, Stock=150, DiscountRate=0.90, CategoryId=2},

               new(){ Id=3, Name="Product C", Description="Product C Description", ImageUrl="https://cdn.dsmcdn.com/ty702/product/media/images/20230126/19/266768229/623370682/11/11_org.jpg", Price=1000, Stock=150, DiscountRate=0.90 , CategoryId = 1},


               new(){ Id=4, Name="Product D", Description="Product D Description", ImageUrl="https://cdn.dsmcdn.com/ty702/product/media/images/20230126/19/266768229/623370682/11/11_org.jpg", Price=1000, Stock=150, DiscountRate=0.90, CategoryId = 4}
            };

            return products;
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
