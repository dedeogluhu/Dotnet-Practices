using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EFConsoleBankAppDemo
{
    public class CustomerDal : ICustomerDal
    {

        public void AddAccount(Customer customer)
        {
            using (ConsoleBankAppDemoContext context = new ConsoleBankAppDemoContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public List<Customer> GetCustomers()
        {
            using (ConsoleBankAppDemoContext context = new ConsoleBankAppDemoContext())
            {
                return context.Customers.ToList();
            }
        }

        public void UpdateCustomers(Customer customer)
        {
            using (ConsoleBankAppDemoContext context = new ConsoleBankAppDemoContext())
            {
                var entity = context.Entry(customer);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
