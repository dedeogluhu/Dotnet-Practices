using OOPPrototype_Rpg.ClassesChosenAbility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Rpg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DamageDealerWarrior _damageDealerWarrior = new DamageDealerWarrior
        {
            Health = 100,
            Cities = HumanCities.Stormshield,
            Damage = 100
        };

        TankWarrior _tankWarrior = new TankWarrior
        {
            Health = 200,
            Cities = HumanCities.Stormwind,
            Damage = 50
        };

        CloseRangeAssassin _closeRangeAssassin = new CloseRangeAssassin
        {
            Health = 100,
            Damage = 50,
            Cities = HumanCities.Ironforge
        };

        ArcherAssassin _archerAssassin = new ArcherAssassin
        {
            Health = 100,
            Cities = HumanCities.Ironforge,
            Damage = 50
        };

        Necromancer _necromancer = new Necromancer
        {
            Health = 100,
            Cities = HumanCities.Stormshield,
            Damage = 50
        };

        Priest _priest = new Priest
        {
            Health = 50,
            Damage = 50,
            Cities = HumanCities.Stormwind
        };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCastTank_Click(object sender, EventArgs e)
        {
            _tankWarrior.Defend();
        }

        private void btnAttackTank_Click(object sender, EventArgs e)
        {
            _tankWarrior.Attack();
        }

        private void btnCastDamageDealer_Click(object sender, EventArgs e)
        {
            _damageDealerWarrior.DealDamage();
        }

        private void btnAttackDamageDealer_Click(object sender, EventArgs e)
        {
            _damageDealerWarrior.Attack();
        }

        private void btnCastStealth_Click(object sender, EventArgs e)
        {
            _closeRangeAssassin.BecomeInvisible();
        }

        private void btnAttackStealth_Click(object sender, EventArgs e)
        {
            _closeRangeAssassin.Attack();
        }

        private void btnCastArcher_Click(object sender, EventArgs e)
        {
            _archerAssassin.LongRangeAttack();
        }

        private void btnAttackArcher_Click(object sender, EventArgs e)
        {
            _archerAssassin.Attack();
        }

        private void btnCastNecromancer_Click(object sender, EventArgs e)
        {
            _necromancer.CastDarkMagic();
        }

        private void btnAttackNecromancer_Click(object sender, EventArgs e)
        {
            _necromancer.Attack();
        }

        private void btnCastPriest_Click(object sender, EventArgs e)
        {
            _priest.Heal();
        }

        private void btnAttackPriest_Click(object sender, EventArgs e)
        {
            _priest.Attack();
        }
    }
}
