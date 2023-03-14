using eshop.Entities;
using System.Linq.Expressions;

namespace eshop.DataOperations.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IList<T> GetAll();
        T? GetById(int id);
        IList<T> GetByCriteria(Expression<Func<T, bool>> criteria);



    }
}
