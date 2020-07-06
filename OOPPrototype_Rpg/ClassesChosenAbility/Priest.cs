using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Rpg.ClassesChosenAbility
{
    class Priest : Mage, IHealer
    {
        public void Heal()
        {
            MessageBox.Show("Priest Casted Heal");
        }
    }
}
