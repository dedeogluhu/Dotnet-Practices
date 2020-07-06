using System;

namespace ConsoleAppDemo_BankApp
{
    class Program
    {


        static void Main(string[] args)
        {

            CustomerDal.AddCustomer(new Customer
            {
                AccountId = 1234,
                Cash = 100,
                Name = "Huseyin Dedeoglu",
                Password = 1234
            });
            CustomerDal.AddCustomer(new Customer
            {
                AccountId = 4321,
                Cash = 200,
                Name = "Ahmet Dedeoglu",
                Password = 4321
            });

            bool isWorking = true;

            while (isWorking)
            {
                OpeningScreen();
            }
        }

        private static void OpeningScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Huso Bank");
            Console.WriteLine("====================");
            Console.WriteLine("Please Choose Your Operation\n\n1-)Login\n2-)Signup \n3-)Exit");
            int openingInput = Int32.Parse(Console.ReadLine());
            if (openingInput == 1)
            {
                LoginScreen();
            }
            else if (openingInput == 2)
            {
                SignupScreen();
            }
            else if (openingInput == 3)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wrong Type of Input\nPress Enter to Return");
                Console.ReadKey();
                Console.WriteLine("Returning...");
                OpeningScreen();
            }
        }

        private static void SignupScreen()
        {
            Console.Clear();
            Console.WriteLine("Your Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Create a 4-digit Account Id:");
            int accountId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Create a 4-digit Password");
            int password = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adding Customer...");

            CustomerDal.AddCustomer(new Customer
            {
                AccountId = accountId,
                Name = name,
                Password = password,
                Cash = 0
            });

            Console.WriteLine("Customer Added \nPress Enter to Return");
            Console.ReadKey();

            OpeningScreen();
        }

        private static void LoginScreen()
        {
            Console.Clear();

            Console.WriteLine("Your Account Id :");
            int accountId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Password :");
            int password = Convert.ToInt32(Console.ReadLine());

            bool foundCustomer = false;

            foreach (var customer in CustomerDal.CustomerList)
            {
                if (customer.AccountId == accountId && customer.Password == password)
                {
                    foundCustomer = true;

                    Loggedin(customer);
                }
            }

            if (!foundCustomer)
            {
                Console.WriteLine("Wrong Password or Id \n Press Enter to Return");
                Console.ReadKey();
                LoginScreen();
            }
        }

        private static void Loggedin(Customer customer)
        {
            Console.Clear();
            Console.WriteLine("Welcome {0}", customer.Name);
            Console.WriteLine("Choose Your Operation :\n\n 1-)Check Balance \n 2-)Deposit \n 3-)Withdraw \n 4-)Transfer \n 5-)Log out");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    CheckBalance(customer);
                    break;
                case 2:
                    DepositCash(customer);
                    break;
                case 3:
                    WithdrawCash(customer);
                    break;
                case 4:
                    TransferCash(customer);
                    break;
                case 5:
                    OpeningScreen();
                    break;

                default:
                    break;
            }

        }

        private static void TransferCash(Customer customer)
        {
            Console.Clear();

            Console.WriteLine("Please Type the Id of the Customer You Want to Transfer To :");
            int id = Convert.ToInt32(Console.ReadLine());

            bool foundCustomerToTransfer = false;

            foreach (var customerEntity in CustomerDal.CustomerList)
            {
                if (customerEntity.AccountId == id)
                {
                    foundCustomerToTransfer = true;

                    Console.WriteLine("Enter the Amount You Want to Transfer");
                    decimal transferAmount = Convert.ToDecimal(Console.ReadLine());

                    if (transferAmount <= customer.Cash)
                    {
                        customer.Cash -= transferAmount;
                        customerEntity.Cash += transferAmount;

                        Console.WriteLine("Transfer Succesful\n Returning to Menu...");
                        Loggedin(customer);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You Don't Have Enough Money to Transfer");
                    }

                }

                if (!foundCustomerToTransfer)
                {
                    Console.WriteLine("Couldn't Found the Customer \n Press Enter to Return");
                    Console.ReadKey();
                    TransferCash(customer);
                }
            }
        }

        private static void WithdrawCash(Customer customer)
        {
            Console.Clear();
            Console.WriteLine("Type the Cash You Want to Withdraw :");
            decimal value = Convert.ToDecimal(Console.ReadLine());

            customer.Cash -= value;

            Console.WriteLine("Press Enter to Return");

            Console.ReadKey();

            Loggedin(customer);
        }

        private static void DepositCash(Customer customer)
        {
            Console.Clear();
            Console.WriteLine("Type the Cash You Want to Deposit");
            decimal value = Convert.ToDecimal(Console.ReadLine());

            customer.Cash += value;

            Console.WriteLine("Press Enter to Return");

            Console.ReadKey();

            Loggedin(customer);
        }

        private static void CheckBalance(Customer customer)
        {
            Console.Clear();
            Console.WriteLine("You Have {0} in Your Account \n Press Enter to Return", customer.Cash.ToString());
            Console.ReadKey();
            Loggedin(customer);
        }
    }
}
