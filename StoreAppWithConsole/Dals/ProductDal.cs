using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAppWithConsole
{
    public static class ProductDal
    {
        static List<Product> productList = new List<Product>();
        public static bool IsSellable { get; set; }

        public static void AddProduct(Product product)
        {
            productList.Add(product);
        }

        public static List<Product> GetProducts()
        {
            return productList;
        }

        public static void SellProduct(Product product, int amount)
        {
            if (product.StockAmount >= amount)
            {
                product.StockAmount -= amount;

                Console.WriteLine("Product Bought \n Press Enter to Return");

                IsSellable = true;

                Console.ReadKey();

                
            }
            else
            {
                Console.WriteLine("Not Enough Stock \n Press Enter to Return");

                IsSellable = false;

                Console.ReadKey();
            }
            
        }

    }
}
