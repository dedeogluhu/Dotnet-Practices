using System.Collections.Generic;

namespace EFConsoleBankAppDemo
{
    interface ICustomerDal
    {
        void AddAccount(Customer customer);
        List<Customer> GetCustomers();
        void UpdateCustomers(Customer customer);
    }
}
