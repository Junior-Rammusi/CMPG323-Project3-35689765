using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetAllCustomer();
        IEnumerable<Customer> FindAllCustomer(Expression<Func<Customer, bool>> expression);
        void AddCustomer(Customer entity);
        void UpdateCustomer(Customer entity);
        void RemoveCustomer(Customer entity);
        void UpdateAllCustomer(IEnumerable<Customer> entities);
        void DeleteAllCustomer(IEnumerable<Customer> entities);
    }
}
