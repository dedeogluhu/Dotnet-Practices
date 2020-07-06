using System.Data.Entity;

namespace EFConsoleBankAppDemo
{
    class ConsoleBankAppDemoContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
