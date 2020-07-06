using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NetDemoWithConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDal productDal = new ProductDal();

            foreach (var item in productDal.GetAllProducts())
            {
                Console.WriteLine("{0}-) Product : {1} Price : {3} Stock :{2}",item.Id, item.Name, item.StockAmount, item.UnitPrice);
            }

            Console.ReadLine();
        }
    }
}
