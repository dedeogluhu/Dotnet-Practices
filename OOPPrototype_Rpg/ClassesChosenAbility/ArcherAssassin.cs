using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Rpg.ClassesChosenAbility
{
    class ArcherAssassin : Assassin, ILongRange
    {
        public void LongRangeAttack()
        {
            MessageBox.Show("Archer Attacked");
        }
    }
}
