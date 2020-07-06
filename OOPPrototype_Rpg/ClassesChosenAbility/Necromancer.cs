using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Rpg.ClassesChosenAbility
{
    class Necromancer : Mage, INecromancer
    {
        public void CastDarkMagic()
        {
            MessageBox.Show("Casted Dark Magic");
        }
    }
}
