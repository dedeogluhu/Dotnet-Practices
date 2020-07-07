using OOPPrototype_Basketball.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Basketball
{
    public partial class Form1 : Form
    {
        PointGuard _stephenCurry;
        ShootingGuard _klayThompshon;
        SmallForward _andrewWiggins;
        PowerForward _draymondGreen;
        Center _willieCauleyStein;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _stephenCurry = new PointGuard { Name = "Stephen Curry", Age = 32 };
            _klayThompshon = new ShootingGuard { Name = "Klay Thompson", Age = 30 };
            _andrewWiggins = new SmallForward { Name = "Andrew Wiggins", Age = 25 };
            _draymondGreen = new PowerForward { Name = "Draymond Green", Age = 30 };
            _willieCauleyStein = new Center { Name = "Willie Cauley Stein", Age = 26 };
        }
    }
}
