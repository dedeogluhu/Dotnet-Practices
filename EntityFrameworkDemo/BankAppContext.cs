using System.Data.Entity;

namespace EntityFrameworkDemo
{
    public class BankAppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
