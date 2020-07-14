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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

            List<Table> tables = new List<Table> { table1, table2, table3 };
            List<Food> foods = new List<Food> { pilav, kuruFasulye, corba };

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
            
        }

    }
}
