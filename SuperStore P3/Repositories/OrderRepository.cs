using Data;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(SuperStoreContext superStoreContext) : base(superStoreContext)
        {
        }

        public void AddOrder(Order entity)
        {
            Add(entity);
        }

        public void DeleteAllOrder(IEnumerable<Order> entities)
        {
            DeleteAll(entities);
        }

        public IEnumerable<Order> FindAllOrder(Expression<Func<Order, bool>> expression)
        {
            return FindAll(expression);
        }

        public Order GetOrder(int id)
        {
            return GetAll().FirstOrDefault(x=>x.OrderId == id);
        }

        public IEnumerable<Order> GetAllOrder()
        {
            return GetAll().ToList();
        }

        public void RemoveOrder(Order entity)
        {
            Remove(entity);
        }

        public void UpdateOrder(Order entity)
        {
            Update(entity);
        }

        public void UpdateAllOrder(IEnumerable<Order> entities)
        {
            UpdateAll(entities);
        }
    }
}
