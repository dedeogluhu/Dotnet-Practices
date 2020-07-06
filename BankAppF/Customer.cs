using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppF
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public int Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Cash { get; set; }
    }
}
