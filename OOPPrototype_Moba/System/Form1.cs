using OOPPrototype_Moba.Classes;
using OOPPrototype_Moba.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPPrototype_Moba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> attackTypes = new List<string> { "Melee", "Ranged"};
            List<string> primaryAttributes = new List<string> { "Strength", "Agility", "Intelligence" };
            List<string> roles = new List<string> { "SafeCarry", "MidLane", "OffLane", "Jungle", "Support" };

            cbxRole.Items.AddRange(roles.ToArray());
            cbxAttackType.Items.AddRange(attackTypes.ToArray());
            cbxPrimaryAttr.Items.AddRange(primaryAttributes.ToArray());

            SafeCarry antiMage = new SafeCarry
            {
                Name = "Anti Mage",
                AttackType = "Melee",
                PrimaryAttribute = "Agility",
                Level = 25,
                SkillName = "Blink",
                UltiName = "Void Space"
            };
            MidLane queenOfPain = new MidLane
            {
                Name = "Queen Of Pain",
                AttackType = "Ranged",
                PrimaryAttribute = "Intelligence",
                Level = 25,
                SkillName = "Blink",
                UltiName = "Scream Of Pain"
            };
            OffLane windRanger = new OffLane
            {
                Name = "WindRanger",
                AttackType = "Ranged",
                PrimaryAttribute = "Intelligence",
                Level = 25,
                SkillName = "Powershot",
                UltiName = "Focus Fire"
            };
            Jungle axe = new Jungle
            {
                Name = "Axe",
                AttackType = "Melee",
                PrimaryAttribute = "Strength",
                Level = 25,
                SkillName = "Berserker's Call",
                UltiName = "Culling Blade"
            };
            Support crystalMaiden = new Support
            {
                Name = "Crystal Maiden",
                AttackType = "Ranged",
                PrimaryAttribute = "Intelligence",
                Level = 25,
                SkillName = "Crystal Nova",
                UltiName = "Freezing Field"
            };

            lbxCharacters.Items.Add(antiMage);
            lbxCharacters.Items.Add(queenOfPain);
            lbxCharacters.Items.Add(windRanger);
            lbxCharacters.Items.Add(axe);
            lbxCharacters.Items.Add(crystalMaiden);


        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            if ((string)cbxRole.SelectedItem == "SafeCarry")
            {
                SafeCarry safeCarry = new SafeCarry
                {
                    Name = tbxName.Text,
                    AttackType = (string)cbxAttackType.SelectedItem,
                    Level = Convert.ToInt32(tbxLevel.Text),
                    PrimaryAttribute = (string)cbxPrimaryAttr.SelectedItem,
                    SkillName = tbxSkillName.Text,
                    UltiName = tbxUltiName.Text
                };
                lbxCharacters.Items.Add(safeCarry);
            }
            else if ((string)cbxRole.SelectedItem == "MidLane")
            {
                MidLane midLane = new MidLane
                {
                    Name = tbxName.Text,
                    AttackType = (string)cbxAttackType.SelectedItem,
                    Level = Convert.ToInt32(tbxLevel.Text),
                    PrimaryAttribute = (string)cbxPrimaryAttr.SelectedItem,
                    SkillName = tbxSkillName.Text,
                    UltiName = tbxUltiName.Text
                };
                lbxCharacters.Items.Add(midLane);
            }
            else if ((string)cbxRole.SelectedItem == "OffLane")
            {
                OffLane offLane = new OffLane
                {
                    Name = tbxName.Text,
                    AttackType = (string)cbxAttackType.SelectedItem,
                    Level = Convert.ToInt32(tbxLevel.Text),
                    PrimaryAttribute = (string)cbxPrimaryAttr.SelectedItem,
                    SkillName = tbxSkillName.Text,
                    UltiName = tbxUltiName.Text
                };

                lbxCharacters.Items.Add(offLane);
            }
            else if ((string)cbxRole.SelectedItem == "Jungle")
            {
                Jungle jungle = new Jungle
                {
                    Name = tbxName.Text,
                    AttackType = (string)cbxAttackType.SelectedItem,
                    Level = Convert.ToInt32(tbxLevel.Text),
                    PrimaryAttribute = (string)cbxPrimaryAttr.SelectedItem,
                    SkillName = tbxSkillName.Text,
                    UltiName = tbxUltiName.Text
                };
                lbxCharacters.Items.Add(jungle);
            }
            else if ((string)cbxRole.SelectedItem == "Support")
            {
                Support support = new Support
                {
                    Name = tbxName.Text,
                    AttackType = (string)cbxAttackType.SelectedItem,
                    Level = Convert.ToInt32(tbxLevel.Text),
                    PrimaryAttribute = (string)cbxPrimaryAttr.SelectedItem,
                    SkillName = tbxSkillName.Text,
                    UltiName = tbxUltiName.Text
                };

                lbxCharacters.Items.Add(support);
            }
            else
            {
                MessageBox.Show("Please Select an Appropriate Role");
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            Character character = (Character)lbxCharacters.SelectedItem;
            MessageBox.Show(character.Attack());
        }

        private void btnUseSkill_Click(object sender, EventArgs e)
        {
            Character character = (Character)lbxCharacters.SelectedItem;
            MessageBox.Show(character.UseSkill());
        }

        private void btnUseUlti_Click(object sender, EventArgs e)
        {
            Character character = (Character)lbxCharacters.SelectedItem;
            MessageBox.Show(character.UseUlti());
        }

        private void btnFarm_Click(object sender, EventArgs e)
        {
            if (lbxCharacters.SelectedItem is IFarmer)
            {
                IFarmer farmer = (IFarmer)lbxCharacters.SelectedItem;
                MessageBox.Show(farmer.Farm());
            }
            else
            {
                MessageBox.Show("My Carries Need This!");
            }
        }

        private void btnBuyWards_Click(object sender, EventArgs e)
        {
            if (lbxCharacters.SelectedItem is ISupport)
            {
                ISupport support = (ISupport)lbxCharacters.SelectedItem;
                MessageBox.Show(support.BuyWards());
            }
            else
            {
                MessageBox.Show("Why Would I Do a Support Job?");
            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (lbxCharacters.SelectedItem is ISupport)
            {
                ISupport support = (ISupport)lbxCharacters.SelectedItem;
                MessageBox.Show(support.Heal());
            }
            else
            {
                MessageBox.Show("Why Would I Do a Support Job?");
            }
        }
    }
}
