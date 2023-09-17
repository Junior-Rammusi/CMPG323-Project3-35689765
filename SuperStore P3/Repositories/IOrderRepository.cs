using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Order GetOrder(int id);
        IEnumerable<Order> GetAllOrder();
        IEnumerable<Order> FindAllOrder(Expression<Func<Order, bool>> expression);
        void AddOrder(Order entity);
        void UpdateOrder(Order entity);
        void RemoveOrder(Order entity);
        void UpdateAllOrder(IEnumerable<Order> entities);
        void DeleteAllOrder(IEnumerable<Order> entities);
    }
}
