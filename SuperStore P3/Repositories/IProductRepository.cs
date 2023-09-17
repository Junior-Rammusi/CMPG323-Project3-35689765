using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetAllProduct();
        IEnumerable<Product> FindAllProduct(Expression<Func<Product, bool>> expression);
        void AddProduct(Product entity);
        void UpdateProduct(Product entity);
        void RemoveProduct(Product entity);
        void UpdateAllProduct(IEnumerable<Product> entities);
        void DeleteAllProduct(IEnumerable<Product> entities);
    }
}
