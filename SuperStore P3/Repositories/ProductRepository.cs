using Data;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(SuperStoreContext superStoreContext) : base(superStoreContext)
        {
        } 
        public void AddProduct(Product entity)
        {
            Add(entity);
        }

        public void DeleteAllProduct(IEnumerable<Product> entities)
        {
            DeleteAll(entities);
        }

        public IEnumerable<Product> FindAllProduct(Expression<Func<Product, bool>> expression)
        {
            return FindAll(expression);
        }

        public Product GetProduct(int id)
        {
          
            return GetAll().FirstOrDefault(x => x.ProductId == id);
            
  
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return GetAll().ToList();
        }

        public void RemoveProduct(Product entity)
        {
            Remove(entity);
        }

        public void UpdateProduct(Product entity)
        {
            Update(entity);
        }

        public void UpdateAllProduct(IEnumerable<Product> entities)
        {
            UpdateAll(entities);
        }
    }
}
