using OOPPrototype_Restaurant.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Restaurant
{
    public partial class Form1 : Form
    {
        List<Worker> workers;
        Form2 form2;
        bool isFormShown = false;
        //static List<Worker> workersToAdd;


        public void AddWorkers(Worker worker)
        {
            //workersToAdd.Add(worker);
            workers.Add(worker);
            lbxWorkers.Items.Add(worker);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //workersToAdd = new List<Worker>();
            form2 = new Form2();

            Food kuruFasulye = new Food
            {
                Name = "Kuru Fasulye",
                Price = 10
            };
            Food pilav = new Food
            {
                Name = "Pilav",
                Price = 15
            };
            Food corba = new Food
            {
                Name = "Tarhana",
                Price = 5
            };

            Table table1 = new Table
            {
                TableNo = "1",
                TotalFee = 0
            };
            Table table2 = new Table
            {
                TableNo = "2",
                TotalFee = 0
            };
            Table table3 = new Table
            {
                TableNo = "3",
                TotalFee = 0
            };

            Worker worker1 = new Worker { Name = "Ali", Age = 20, Wage = 100 };
            Worker worker2 = new Worker { Name = "Ayşe", Age = 25, Wage = 80 };
            Worker worker3 = new Worker { Name = "Aylin", Age = 21, Wage = 120 };

            workers = new List<Worker> { worker1, worker2, worker3 };
            List<Table> tables = new List<Table> { table1, table2, table3 };
            List<Food> foods = new List<Food> { pilav, kuruFasulye, corba };

            lbxWorkers.Items.AddRange(workers.ToArray());
            lbxMenu.Items.AddRange(foods.ToArray());
            cbxTableNo.Items.AddRange(tables.ToArray());
            lbxTableListForPayment.Items.AddRange(tables.ToArray());


        }

        private void btnAddFoodToList_Click(object sender, EventArgs e)
        {
            Food food = (Food)lbxMenu.SelectedItem;

            lbxFoodToOrder.Items.Add(food);
            lblTotalAmount.Text = (Convert.ToInt32(lblTotalAmount.Text) + food.Price).ToString();
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {
            Table table1 = (Table)cbxTableNo.SelectedItem;

            lbxTableListForPayment.Items.Remove(table1);

            Random random = new Random();

            int index = random.Next(workers.Count);

            Table table = new Table
            {
                TableNo = table1.TableNo,
                TotalFee = Convert.ToInt32(lblTotalAmount.Text),
                Waiter = workers[index]
            };

            lbxTableListForPayment.Items.Add(table);

            foreach (Food item in lbxFoodToOrder.Items)
            {
                lbxOrderListForCook.Items.Add(item);
            }

            lbxFoodToOrder.Items.Clear();
            lblTotalAmount.Text = "0";
 
        }

        private void btnGetPayment_Click(object sender, EventArgs e)
        {
            Table table = (Table)lbxTableListForPayment.SelectedItem;
            lbxOldOrders.Items.Add(table);
            lblShowCash.Text = (Convert.ToInt32(lblShowCash.Text) + table.TotalFee).ToString();
            MessageBox.Show($"{table.TotalFee}$ Payment");
            table.Payment();
            lbxTableListForPayment.Items.Remove(table);
            lbxTableListForPayment.Items.Add(table);
        }

        private void btnOrderReady_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{lbxOrderListForCook.SelectedItem} is Ready!");
            lbxOrderListForCook.Items.Remove(lbxOrderListForCook.SelectedItem);
        }

        private void btnWithdrawCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{lblShowCash.Text}$ Withdraw..");
            lblShowCash.Text = "0";
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            if (isFormShown == false)
            {
                form2.Show();

                form2.AddWorkerEvent += AddWorkers;

                isFormShown = true;
            }
            else if (isFormShown == true)
            {
                isFormShown = false;
            }
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //lbxWorkers.Items.AddRange(workersToAdd.ToArray());
            //workersToAdd.Clear();
            form2.AddWorkerEvent -= AddWorkers;
        }

        private void btnRemoveWorker_Click(object sender, EventArgs e)
        {
            lbxWorkers.Items.Remove(lbxWorkers.SelectedItem);
        }
    }
}
