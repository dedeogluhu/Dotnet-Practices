using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppF
{
    public class HusoBankContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
