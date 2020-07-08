using OOPPrototype_Fps.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Fps
{
    public partial class Form1 : Form
    {
        Soldiers _soldier;
        Pistol _magnum;
        Shotgun _uzas;
        MachineGun _ak47;
        Sniper _awp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _magnum = new Pistol { Name = "Magnum", Ammo = 7, Damage = 10 };
            _uzas = new Shotgun { Name = "UZAS", Ammo = 10, Damage = 30 };
            _ak47 = new MachineGun { Name = "AK47", Ammo = 30, Damage = 20 };
            _awp = new Sniper { Name = "AWP", Ammo = 10, Damage = 30 };


            _soldier = new Soldiers { Name = "SKCNZM", Health = 100, Weapon = _magnum };
        }

        private void btnPistol_Click(object sender, EventArgs e)
        {

        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {

        }

        private void btnMachineGun_Click(object sender, EventArgs e)
        {

        }

        private void btnSniper_Click(object sender, EventArgs e)
        {

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSoldier_Click(object sender, EventArgs e)
        {

        }
    }
}
