using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EFDemo2
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (BankAppContext context = new BankAppContext())
            {
                return context.Products.ToList();
            }
        }

        public void AddProduct(Product product)
        {
            using (BankAppContext context = new BankAppContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (BankAppContext context = new BankAppContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void RemoveProduct(Product product)
        {
            using (BankAppContext context = new BankAppContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
