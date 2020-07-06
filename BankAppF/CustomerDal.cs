using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppF
{
    public class CustomerDal
    {
        public decimal GetCash()
        {
            using (HusoBankContext context = new HusoBankContext())
            {
                return 0;
            }
        }

        public void AddCustomer(Customer customer)
        {
            using (HusoBankContext context = new HusoBankContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void CustomerLogin()
        {

        }
    }
}
