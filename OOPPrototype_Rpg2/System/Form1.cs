using OOPPrototype_Rpg2.Characters;
using OOPPrototype_Rpg2.Spells;
using OOPPrototype_Rpg2.Weapons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Rpg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Spell spell1 = new Fireball
            {
                Name = "Spell1",
                Damage = 30,
                ManaNeeded = 30
            };

            cbxSpell.Items.Add(spell1);

            Weapon weapon1 = new Staff
            {
                Name = "Staff1",
                Damage = 30,
                Durability = 30
            };

            cbxWeapon.Items.Add(weapon1);

            Character character1 = new Mage
            {
                Name = "Mage1",
                Health = 100,
                Mana = 100,
                SpellLearned = spell1,
                WeaponOwned = weapon1
            };

            List<string> charTypes = new List<string> { "Warrior", "Archer", "Mage" };

            cbxType.Items.AddRange(charTypes.ToArray());
        }

        private void btnAddChar_Click(object sender, EventArgs e)
        {
            switch (cbxType.SelectedItem)
            {
                case "Warrior":
                    Warrior warrior = new Warrior
                    {
                        Name = tbxCharName.Text,
                        Health = 100,
                        Mana = 100,
                        SpellLearned = (Spell)cbxSpell.SelectedItem,
                        WeaponOwned = (Weapon)cbxWeapon.SelectedItem
                    };

                    lbxChar.Items.Add(warrior);
                    break;

                case "Archer":
                    Archer archer = new Archer
                    {
                        Name = tbxCharName.Text,
                        Health = 100,
                        Mana = 100,
                        SpellLearned = (Spell)cbxSpell.SelectedItem,
                        WeaponOwned = (Weapon)cbxWeapon.SelectedItem
                    };
                    lbxChar.Items.Add(archer);
                    break;
                    
                case "Mage":
                    Mage mage = new Mage
                    {
                        Name = tbxCharName.Text,
                        Health = 100,
                        Mana = 100,
                        SpellLearned = (Spell)cbxSpell.SelectedItem,
                        WeaponOwned = (Weapon)cbxWeapon.SelectedItem
                    };
                    lbxChar.Items.Add(mage);
                    break;
            }
        }
    }
}
