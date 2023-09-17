using Data;
using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SuperStoreContext superStoreContext) :base(superStoreContext)
        {

        }

        public void AddCustomer(Customer entity)
        {
            Add(entity);
        }
        public void DeleteAllCustomer(IEnumerable<Customer> entities)
        {
            DeleteAll(entities);
        }

        public IEnumerable<Customer> FindAllCustomer(Expression<Func<Customer, bool>> expression)
        {
            return FindAll(expression);
        }

        public void RemoveCustomer(Customer entity)
        {
           Remove(entity);
        }


        public void UpdateCustomer(Customer entity)
        {
            Update(entity);
        }

        public void UpdateAllCustomer(IEnumerable<Customer> entities)
        {
            UpdateAll(entities);
        }

        public Customer GetCustomer(int id)
        {
            return GetAll().FirstOrDefault(x=>x.CustomerId==id);
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return GetAll().ToList();
        }
    }
}
