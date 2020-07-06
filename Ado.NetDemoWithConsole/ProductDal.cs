using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NetDemoWithConsole
{
    public class ProductDal
    {
        public List<Product> GetAllProducts()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=Etrade; integrated security = true");

            connection.Open();

            SqlCommand command = new SqlCommand("Select * From Products", connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };

                products.Add(product);
            }

            reader.Close();

            connection.Close();

            return products;
        }
    }
}
