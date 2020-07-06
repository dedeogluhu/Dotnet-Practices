using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Rpg
{
    class TankWarrior : Warrior, IArmored
    {
        public void Defend()
        {
            MessageBox.Show("Defended by Warrior");
        }
    }
}
