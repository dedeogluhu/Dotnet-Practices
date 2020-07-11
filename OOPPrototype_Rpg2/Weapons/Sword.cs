using OOPPrototype_Rpg2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrototype_Rpg2.Weapons
{
    public class Sword : Weapon, ICloseRange
    {
        public string Slash()
        {
            return "Attacking....";
        }
    }
}
