using Data;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(SuperStoreContext superStoreContext) : base(superStoreContext) 
        {
        }

        public void AddOrderDetail(OrderDetail entity)
        {
            Add(entity);
        }

        public void DeleteAllOrderDetail(IEnumerable<OrderDetail> entities)
        {
            DeleteAll(entities);
        }

        public IEnumerable<OrderDetail> FindAllOrderDetail(Expression<Func<OrderDetail, bool>> expression)
        {
            return FindAll(expression);
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return GetAll().FirstOrDefault(x=>x.OrderDetailsId == id);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetail()
        {
            return GetAll().ToList();
        }

        public void RemoveOrderDetail(OrderDetail entity)
        {
            Remove(entity);
        }

        public void UpdateOrderDetail(OrderDetail entity)
        {
            Update(entity);
        }

        public void UpdateAllOrderDetail(IEnumerable<OrderDetail> entities)
        {
            UpdateAll(entities);
        }

    }
}
