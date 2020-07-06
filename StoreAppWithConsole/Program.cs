using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace StoreAppWithConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductDal.AddProduct(new Product { Name = "Apple", UnitPrice = 15, StockAmount = 100 });
            CustomerDal.AddCustomer(new Customer { Id = 1234, Name = "Admin", Cash = 250, Password = 1234 });
            ProducerDal.AddProducer(new Producer { Id = 4321, Name = "Admin2", Cash = 350, Password = 4321 });

            while (true)
            {
                FirstScreen();
            }

        }

        private static void FirstScreen()
        {
            Console.Clear();

            Console.WriteLine(@"
            WELCOME TO HUSO BANK
            ");

            Console.WriteLine("Please Choose Your Operation \n 1-)Producer Login \n 2-)Producer Signup \n 3-)Customer Login \n 4-)Customer Signup \n 5-)Exit");
            int input = Int32.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    ProducerLoginScreen();
                    break;
                case 2:
                    ProducerSignupScreen();
                    break;
                case 3:
                    CustomerLoginScreen();
                    break;
                case 4:
                    CustomerSignupScreen();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

        }

        private static void CustomerSignupScreen()
        {
            Console.WriteLine("Your Name :");
            string inputName = Console.ReadLine();
            Console.WriteLine("Type a 4-digit Id :");
            int inputId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a 4-digit Password");
            int inputPassword = Convert.ToInt32(Console.ReadLine());

            Customer customer = new Customer { Name = inputName, Id = inputId, Password = inputPassword, Cash = 0 };

            if (!CustomerDal.GetCustomers().Contains(customer))
            {
                CustomerDal.AddCustomer(customer);
                Console.WriteLine("Customer Added \n Press Enter to Return");
                Console.ReadKey();
                FirstScreen();

            }
            else
            {
                Console.WriteLine("The Customer Already Exists");
                CustomerSignupScreen();
            }

        }

        private static void ProducerSignupScreen()
        {
            Console.WriteLine("Your Name :");
            string inputName = Console.ReadLine();
            Console.WriteLine("Type a 4-digit Id :");
            int inputId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a 4-digit Password");
            int inputPassword = Convert.ToInt32(Console.ReadLine());

            Producer producer = new Producer { Name = inputName, Id = inputId, Password = inputPassword, Cash = 0 };

            if (!ProducerDal.GetProducers().Contains(producer))
            {
                ProducerDal.AddProducer(producer);
                Console.WriteLine("Producer Added \n Press Enter to Return");
                Console.ReadKey();
                FirstScreen();

            }
            else
            {
                Console.WriteLine("The Producer Already Exists");
                ProducerSignupScreen();
            }

        }

        private static void ProducerLoginScreen()
        {
            Console.WriteLine("Your Id : ");
            int inputId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Password :");
            int inputPassword = Int32.Parse(Console.ReadLine());

            foreach (var item in ProducerDal.GetProducers())
            {
                if (item.Id == inputId && item.Password == inputPassword)
                {
                    Console.WriteLine("Welcome {0}", item.Name);

                    AfterProducerLogin(item);
                }
            }

        }

        private static void AfterProducerLogin(Producer producer)
        {
            Console.Clear();

            Console.WriteLine("Welcome {0}", producer.Name);

            Console.WriteLine("Choose Your Operation : \n 1-)Add a Product \n 2-)Check Balance \n 3-)Withdraw Cash \n 4-)Logout");
            int input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Product Name :");
                    string inputName = Console.ReadLine();
                    Console.WriteLine("Unit Price :");
                    decimal inputPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Stock :");
                    int inputStock = Int32.Parse(Console.ReadLine());

                    Product product = new Product { Name = inputName, UnitPrice = inputPrice, StockAmount = inputStock };

                    if (!ProductDal.GetProducts().Contains(product))
                    {
                        ProductDal.AddProduct(product);
                        Console.WriteLine("Product Added");
                    }
                    else
                    {
                        Console.WriteLine("Product Already Exists");
                    }

                    Console.WriteLine("Press Enter to Return");
                    Console.ReadKey();

                    AfterProducerLogin(producer);

                    break;
                case 2:

                    Console.WriteLine("You Have {0} in Your Account \n Press Enter to Return", producer.Cash);
                    Console.ReadKey();

                    AfterProducerLogin(producer);

                    break;
                case 3:

                    Console.WriteLine("Enter the Amount to Withdraw :");
                    decimal inputWithdraw = Convert.ToDecimal(Console.ReadLine());

                    if (inputWithdraw <= producer.Cash)
                    {
                        producer.Cash -= inputWithdraw;

                        Console.WriteLine("Press Enter to Return");
                        Console.ReadKey();
                        AfterProducerLogin(producer);
                    }
                    else
                    {
                        Console.WriteLine("You Don't Have Enough Cash to Do This Operation \n Press Enter to Return");
                        Console.ReadKey();
                        AfterProducerLogin(producer);

                    }
                    break;

                case 4:
                    Console.WriteLine("Press Enter to Return to the Main Menu");
                    Console.ReadKey();
                    FirstScreen();
                    break;
                default:
                    break;
            }
        }

        private static void AfterCustomerLogin(Customer customer)
        {
            Console.Clear();

            Console.WriteLine("Welcome {0}", customer.Name);

            Console.WriteLine("Choose Your Operation : \n 1-)Check Balance \n 2-)Deposit Cash \n 3-)See Product List \n 4-)Logout");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("You Have {0} in Your Account \n Press Enter to Return", customer.Cash);
                    Console.ReadKey();
                    AfterCustomerLogin(customer);
                    break;

                case 2:
                    Console.WriteLine("Enter to Value You Want to Deposit :");
                    decimal inputCash = Convert.ToDecimal(Console.ReadLine());

                    customer.Cash += inputCash;
                    Console.WriteLine("Cash Deposited");
                    Console.WriteLine("Press Enter to Return");
                    Console.ReadKey();

                    AfterCustomerLogin(customer);
                    break;

                case 3:

                    var a = ProductDal.GetProducts();

                    for (int i = 0; i < a.Count(); i++)
                    {
                        Console.WriteLine("{3} Product Name : {0}, Unit Price : {1}, Stock Amount : {2}", a[i].Name, a[i].UnitPrice, a[i].StockAmount, i + 1);
                    }

                    Console.WriteLine("\n Enter the Index of the Product You Want to Buy :");
                    int inputBuy = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Enter the Amount You Want to Buy");
                    int inputBuyAmount = Convert.ToInt32(Console.ReadLine());

                    ProductDal.SellProduct(a[inputBuy - 1], inputBuyAmount);

                    AfterCustomerLogin(customer);

                    break;

                case 4:
                    Console.WriteLine("Press Enter to Return to Main Menu");
                    Console.ReadKey();
                    FirstScreen();
                    break;

                default:
                    break;
            }
        }

        private static void CustomerLoginScreen()
        {
            Console.WriteLine("Your Id : ");
            int inputId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Password :");
            int inputPassword = Int32.Parse(Console.ReadLine());

            foreach (var customer in CustomerDal.GetCustomers())
            {
                if (customer.Id == inputId && customer.Password == inputPassword)
                {
                    Console.WriteLine("Welcome {0}", customer.Name);

                    AfterCustomerLogin(customer);
                }
            }
        }
    }
}
