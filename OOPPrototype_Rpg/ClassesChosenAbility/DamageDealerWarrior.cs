using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Rpg
{
    public class DamageDealerWarrior : Warrior, IDamageDealer
    {
        public void DealDamage()
        {
            MessageBox.Show("Damage Dealed by Warrior");
        }
    }
}
