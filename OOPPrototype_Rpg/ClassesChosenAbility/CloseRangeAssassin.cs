using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Rpg.ClassesChosenAbility
{
    class CloseRangeAssassin : Assassin, IStealth
    {
        public void BecomeInvisible()
        {
            MessageBox.Show("Assassin Became Invisible");
        }
    }
}
