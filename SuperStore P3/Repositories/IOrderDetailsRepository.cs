using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public interface IOrderDetailsRepository : IGenericRepository<OrderDetail>
    {
        OrderDetail GetOrderDetail(int id);
        IEnumerable<OrderDetail> GetAllOrderDetail();
        IEnumerable<OrderDetail> FindAllOrderDetail(Expression<Func<OrderDetail, bool>> expression);
        void AddOrderDetail(OrderDetail entity);
        void UpdateOrderDetail(OrderDetail entity);
        void RemoveOrderDetail(OrderDetail entity);
        void UpdateAllOrderDetail(IEnumerable<OrderDetail> entities);
        void DeleteAllOrderDetail(IEnumerable<OrderDetail> entities);
    }
}
