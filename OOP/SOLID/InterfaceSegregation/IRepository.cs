namespace InterfaceSegregation
{

    public interface IEntity
    {

    }
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public interface IRepository<T> where T : class, IEntity, new()
    {
        IList<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);

        T Get(int id);


    }

    public interface IProductRepository : IRepository<Product>
    {
        IList<Product> SearchByPrice(double price);
    }

    public interface ICategoryRepository : IRepository<Category>
    {

    }



    public class CategoryRepository : ICategoryRepository
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAll()
        {
            throw new NotImplementedException();
        }



        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
