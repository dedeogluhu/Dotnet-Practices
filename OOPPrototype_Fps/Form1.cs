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
        Weapons _currentWeapon;

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
            _currentWeapon = _magnum;

            cbxWeapon.Items.Add(_magnum);
            cbxWeapon.Items.Add(_uzas);
            cbxWeapon.Items.Add(_ak47);
            cbxWeapon.Items.Add(_awp);


            _soldier = new Soldiers { Name = "SKCNZM", Health = 100, Weapon = _magnum };
            listBox1.Items.Add(_soldier);
        }

        private void btnPistol_Click(object sender, EventArgs e)
        {
            _currentWeapon = _magnum;
            _soldier.Weapon = _currentWeapon;
            MessageBox.Show("Pistol Equipped");
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            _currentWeapon = _uzas;
            _soldier.Weapon = _currentWeapon;
            MessageBox.Show("Shotgun Equipped");
        }

        private void btnMachineGun_Click(object sender, EventArgs e)
        {
            _currentWeapon = _ak47;
            _soldier.Weapon = _currentWeapon;
            MessageBox.Show("Machine Gun Equipped");
        }

        private void btnSniper_Click(object sender, EventArgs e)
        {
            _currentWeapon = _awp;
            _soldier.Weapon = _currentWeapon;
            MessageBox.Show("Sniper Equipped");
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_soldier.Aim());
            MessageBox.Show(_soldier.Shoot());
        }

        private void btnAddSoldier_Click(object sender, EventArgs e)
        {
            Soldiers soldier = new Soldiers
            {
                Name = tbxName.Text,
                Health = 100,
                Weapon = (Weapons)cbxWeapon.SelectedItem
            };
            listBox1.Items.Add(soldier);
        }
    }
}
