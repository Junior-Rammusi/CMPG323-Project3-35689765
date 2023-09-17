using Data;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SuperStoreContext _context;
        
        public GenericRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException($"{(nameof(Add))}entity must not be null");
            }
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new ArgumentNullException($"{(nameof(entity))} could not be saved:{ex.Message}");
            }
        }

        public void DeleteAll(IEnumerable<T> entities)
        {
            DeleteAll(entities);
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> expression)
        {
            return FindAll(expression);
        }

        public T Get(int id)
        {
            return Get(id);
        }

        public IEnumerable<T> GetAll()
        {
            return (IEnumerable<T>)_context.Set<T>();
        }

        public void Remove(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            Update(entity);
        }

        public void UpdateAll(IEnumerable<T> entities)
        {
            UpdateAll(entities);
        }
    }
}
