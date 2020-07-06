using System.Collections.Generic;

namespace ConsoleAppDemo_BankApp
{
    public class CustomerDal
    {
        public static List<Customer> CustomerList = new List<Customer>(); //{ get; set; }



        public static void AddCustomer(Customer customer)
        {
            CustomerList.Add(customer);
        }

    }
}
