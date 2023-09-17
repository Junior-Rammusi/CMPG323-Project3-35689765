using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> FindAll(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void UpdateAll(IEnumerable<T> entities);
        void DeleteAll(IEnumerable<T> entities);
    }

}
