using System.Data.Entity;

namespace EFDemo2
{
    class BankAppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
