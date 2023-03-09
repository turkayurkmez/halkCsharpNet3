namespace GenericTypes
{
    public interface IRepository<T> where T : IEntity, new()
    {
        void Add(T entity);
        void Remove(T entity);
        T GetById(int id);
    }


    public interface IEntity
    {

    }

    public class Product : IEntity
    {

    }

    public class Category : IEntity
    {

    }
}
