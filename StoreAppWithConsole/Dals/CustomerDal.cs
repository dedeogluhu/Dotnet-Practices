using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAppWithConsole
{
    public static class CustomerDal
    {
        static List<Customer> customerList = new List<Customer>();

        public static void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
        }

        public static List<Customer> GetCustomers()
        {
            return customerList;
        }
    }
}
