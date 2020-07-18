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
    public partial class Form2 : Form
    {
        public delegate void AddWorkerDelegate(Worker worker);
        public event AddWorkerDelegate AddWorkerEvent;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker
            {
                Name = tbxWorkerName.Text,
                Age = Convert.ToInt32(tbxWorkerAge.Text),
                Wage = Convert.ToInt32(tbxWorkerWage.Text)
            };

            //Form1.AddWorkers(worker);

            AddWorkerEvent?.Invoke(worker);

            MessageBox.Show("Worker Added");
        }
    }
}
