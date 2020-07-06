namespace EFConsoleBankAppDemo
{
    public class AfterLogin
    {

        public static void CheckCash(Customer customer)
        {
            CustomerDal _customerDal = new CustomerDal();

            _customerDal.GetCustomers();
        }
        public static void DepositCash()
        {
            CustomerDal _customerDal = new CustomerDal();
        }
        public static void WithdrawCash()
        {
            CustomerDal _customerDal = new CustomerDal();
        }
        public static void TransferCash()
        {
            CustomerDal _customerDal = new CustomerDal();
        }
    }
}
