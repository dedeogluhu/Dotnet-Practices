using System;

namespace EFConsoleBankAppDemo
{
    class Program
    {
        CustomerDal _customerDal = new CustomerDal();

        static void Main(string[] args)
        {
            bool isWorking = true;
            //Customer customer;

            while (isWorking)
            {
                Console.WriteLine("Welcome to Our Bank\nPlease Select Your Operation\n1-)Login\n2-)Signup");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Login();
                }
                else if (input == 2)
                {
                    SignUp();
                }
                else
                {
                    Console.WriteLine("Please Enter A Valid Choice");
                }


                isWorking = false;
            }

            Console.ReadLine();
        }

        private static void Login()
        {
            CustomerDal _customerDal = new CustomerDal();


            Console.WriteLine("Id :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Password");
            int password = Convert.ToInt32(Console.ReadLine());

            foreach (var item in _customerDal.GetCustomers())
            {
                if (item.AccountId == id)
                {
                    if (item.Password == password)
                    {
                        Console.WriteLine("Login Succesful\nLoading...");
                    }
                    LoggedInScreen();
                }
            }
        }

        private static void LoggedInScreen()
        {
            Console.WriteLine("Choose Your Operation\n\n1-)Check Cash\n2-)Deposit\n3-)Withdraw\n4-)Transfer");
            int input = Convert.ToInt32(Console.ReadLine());

            /*switch (input)
            {
                case 1:
                    AfterLogin.CheckCash(customer);
                    break;
                case 2:
                    AfterLogin.DepositCash();
                    break;
                case 3:
                    AfterLogin.WithdrawCash();
                    break;
                case 4:
                    AfterLogin.TransferCash();
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Choice");
                    break;
            }*/





        }

        static void SignUp()
        {
            CustomerDal _customerDal = new CustomerDal();

            Console.WriteLine("FirstName :");
            string firstName = Console.ReadLine();
            Console.WriteLine("LastName :");
            string lastName = Console.ReadLine();
            Console.WriteLine("4-digit Id :");
            int accountId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Password :");
            int password = Convert.ToInt32(Console.ReadLine());

            _customerDal.AddAccount(new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                AccountId = accountId,
                Password = password
            });
        }
    }
}
