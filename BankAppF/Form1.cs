using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CustomerDal _customerDal = new CustomerDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _customerDal.CustomerLogin();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            _customerDal.AddCustomer(new Customer
            {
                CustomerId = tbxSignupId.Text,
                FirstName = tbxSignupFirstName.Text,
                LastName = tbxSignupLastName.Text,
                Password = Convert.ToInt32(tbxSignupPwd.Text),
                Cash = 0
            }); ;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

        }
    }
}
